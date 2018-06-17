using MyBlog.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                //for routes identified as server-side routes
                //constraints: new
                //{
                //    serverRoute = new ServerRouteConstraint(url =>
                //   {
                //       return url.PathAndQuery.StartsWith("/About", StringComparison.CurrentCultureIgnoreCase);
                //   })
                //}

            );

            //when no other routes matched. let angular takes care of it
            //routes.MapRoute(
            //   name: "Angular",
            //   url: "{*url}",
            //   defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //   );
        }
    }
}
