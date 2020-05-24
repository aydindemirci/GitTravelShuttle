using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace TravelShuttle.WebUI.MiddleWares
{

    public static class RouteConfig
    {
        public static IRouteBuilder Use(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Robots.txt", "robots.txt", new { controller = "Home", action = "Robots" });
            routeBuilder.MapRoute("SiteMap.xml", "SiteMap.xml", new { controller = "Home", action = "SiteMap" });

            return routeBuilder;
        }
    }

}
