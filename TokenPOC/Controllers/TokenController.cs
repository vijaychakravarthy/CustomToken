using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TokenPOC.Common;

namespace TokenPOC.Controllers
{
    public class TokenController : ApiController
    {
        private string email;
        [AllowAnonymous]
        public string Get(string aadToken)
        {
            if (CheckUser(aadToken))
            {
                return JWTManager.GenerateToken(email);
            }

            throw new HttpResponseException(HttpStatusCode.Unauthorized);
        }

        public bool CheckUser(string aadToken)
        {
            //Should verify with AAD and setup email
            this.email = "vijay@abc.com";
            return true;
        }
    }
}