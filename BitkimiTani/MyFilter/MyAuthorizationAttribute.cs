using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using EntityClassLibrary;
using DataClassLibrary;
using System.Threading;
using System.Security.Principal;

namespace BitkimiTani.MyFilter
{
    public class MyAuthorizationAttribute : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            //ilk önce oturum kontrolu yapılacak
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
            else
            {
                // Oturum var ise kullanıcı Email ve şifresini alacagız
                var tokenKey = actionContext.Request.Headers.Authorization.Parameter;
                var userNamePassword = Encoding.UTF8.GetString(Convert.FromBase64String(tokenKey));
                var userInfoArray = userNamePassword.Split(':');
                var Email = userInfoArray[0];
                var Sifre = userInfoArray[1];
                LoginDB login = new LoginDB();

                if (login.KullaniciEmailVeSifre(Email, Sifre).Count > 0)
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(Email), null);
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                }
            }

        }

    }
}