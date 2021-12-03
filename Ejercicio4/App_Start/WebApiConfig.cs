using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Ejercicio4
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();
            //Agregar
            config.Routes.MapHttpRoute(
                name: "Agregar",
                routeTemplate: "{controller}/{action}/{id}",
                defaults: new { controller = "Values",action="Create", id = RouteParameter.Optional },
    
                constraints: new { id = "/d+" }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
