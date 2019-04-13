using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;
using BitkimiTani.MyFilter;
using Newtonsoft.Json.Serialization;

namespace BitkimiTani
{
    //[MyAuthorization]
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            // Web API configuration and services
            //TODO: Aşağıdaki kod Json Formatına Dönüştürüyor.
            config.Formatters.JsonFormatter.SupportedMediaTypes
    .Add(new MediaTypeHeaderValue("text/html"));
            //Sonuç degerlerin Girintili olması için
            config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
            //Sonuç degerleri Camel Case yapmak için aşg. kod yazılır.
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            // Web API routes
            config.MapHttpAttributeRoutes();

            //Oluşturdugum validationları her defasında eklmemek için buraya da yazıyorum.
            config.Filters.Add(new MyModelValidationAttribute());

            //SSL sertifika zorunlugu getirerek tüm projede kontrolu yapılıyor burada;
            // config.Filters.Add(new RequrieSSLAttribute());

            config.Routes.MapHttpRoute(
                 name: "Bitkimi Tani",
                 routeTemplate: "api/{controller}/{action}/{id}",
                 defaults: new { id = RouteParameter.Optional }
             );


            //NOT:  Bir api çağrısı yapacağımız zaman örnek olarak www.bitkimitani.com/api/controlleradı/metodismi/parametre olarak çağırmamız gerekiyor.


            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}
