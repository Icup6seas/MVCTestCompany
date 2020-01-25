namespace MVCTestCompany
{
    using System.Web.Mvc;
    using System.Web.Routing;

    /// <summary>
    /// Defines the <see cref="RouteConfig" />
    /// </summary>
    public class RouteConfig
    {
        /// <summary>
        /// The RegisterRoutes
        /// </summary>
        /// <param name="routes">The routes<see cref="RouteCollection"/></param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Employee", // route
                "Employee/{action}/{name}", // URL with parameters
                new { controller = "Employee", action = UrlParameter.Optional, name = UrlParameter.Optional } //parameter defaults
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
