
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Serq.WebApi.BasicAuth.Security
{
    public class DBBasicAuthenticationAttribute : BasicAuthenticationAttribute
    {
        protected override Task<IPrincipal> AuthenticateAsync(string userName, string password, CancellationToken cancellationToken)
        {
            IPrincipal princ = null;
            bool authenticated = AuthenticateUser(userName, password);
            if(authenticated)
            {
                princ = new ClaimsPrincipal(new GenericIdentity(userName));
            }
            return Task.FromResult(princ as IPrincipal);
        }

        private bool AuthenticateUser(string username, string password)
        {
            // TODO: run your authentication logic in here, and return whether the user is authenticated
            return true;
        }
    }
}