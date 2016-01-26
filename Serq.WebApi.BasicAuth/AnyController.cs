using Serq.WebApi.BasicAuth.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Serq.WebApi.BasicAuth
{
    [DBBasicAuthenticationAttribute]
    [Authorize]
    public class AnyController : ApiController
    {
           public string GetString()
           {
                return "some string";
           }
    }
}