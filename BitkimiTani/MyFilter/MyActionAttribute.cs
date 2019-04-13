using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace BitkimiTani.MyFilter
{
    public class MyActionAttribute:ActionFilterAttribute
    {
        //Action Çalışmadan önceki durum
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
           //TODO buraya da çalış
                base.OnActionExecuting(actionContext);
        }

        //Çalıştıktan sonraki durum
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            base.OnActionExecuted(actionExecutedContext);
        }
    }
}