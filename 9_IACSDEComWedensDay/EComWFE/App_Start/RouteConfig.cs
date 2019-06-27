using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EComWFE
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {   //http://localhost:45454/
            //http://localhost:4545/products/list/56
            //http://localhost:/my/test.axd
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

             routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "index", id = UrlParameter.Optional }
            ); 

        }
    }
}
