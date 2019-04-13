using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web; 
using System.Web.Http.Filters;
using EntityClassLibrary;
using DataClassLibrary;
using System.Net;

namespace BitkimiTani.MyFilter
{
    public class MyErrorAttribute:ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            // 1.Adım Loglama
            //LoggerDB.LogYaz(actionExecutedContext.Exception.Message, actionExecutedContext.Exception.StackTrace);

            //2. Response Hazırlama
            MyErrorResponseEn result = new MyErrorResponseEn();
            result.HataOlayi = actionExecutedContext.ActionContext.ActionDescriptor.ActionName;
            result.HataKontrolir = actionExecutedContext.ActionContext.ControllerContext.ControllerDescriptor.ControllerName;
            result.HataMesaji = actionExecutedContext.Exception.ToString();
            result.HataZamani = DateTime.Now.ToUniversalTime();// Yazımı dogrumu onu ögren

            actionExecutedContext.Response = actionExecutedContext.Request.CreateResponse(HttpStatusCode.BadRequest, result);
        }
    }
}