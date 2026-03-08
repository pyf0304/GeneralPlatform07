using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using GeneralPlatform.Webform;

namespace WebApi2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            EnableCorsAttribute cors1 = null;
            string strOrigins = clsMyConfig.spCorsOrigins;
            //clsPubVar.objLog.WriteDebugLog(strOrigins);
            if (string.IsNullOrEmpty(strOrigins) == false)
            {
                cors1 = new EnableCorsAttribute(strOrigins, "*", "*"); ;
            }
            else
            {
                cors1 = new EnableCorsAttribute("http://localhost:49550,http://localhost:49550, http://localhost:2408,http://www.sh-tz.com/", "*", "*");
            }
            //var cors2 = new EnableCorsAttribute("http://localhost:49551", "*", "*");
            //var cors3 = new EnableCorsAttribute("http://localhost:49552", "*", "*");
            //[EnableCors(origins: "http://localhost:49540", headers: "*", methods: "*")]
            config.EnableCors(cors1);
            //config.EnableCors(cors2);
            //config.EnableCors(cors3);
            //config.EnableCors();
            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Filters.Add(new WebApiExceptionFilterAttribute());
        }

      
    }
}
