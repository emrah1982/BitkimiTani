using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace BitkimiTani.MyFilter
{
    public class RequrieSSLAttribute:AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.RequestUri.Scheme !=Uri.UriSchemeHttps)
            {
                actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Forbidden)
                {
                    ReasonPhrase = "SSL Zorunludur."
                };
            }
            else
            {
                base.OnAuthorization(actionContext);
            }
           
        }

    }
}