using System.Web.Mvc;
using System.Web.Routing;
using Chj.Web.Framework.Mvc.Routes;

namespace Chj.Plugin.ExternalAuth.Facebook
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Plugin.ExternalAuth.Facebook.Login",
                 "Plugins/ExternalAuthFacebook/Login",
                 new { controller = "ExternalAuthFacebook", action = "Login" },
                 new[] { "Chj.Plugin.ExternalAuth.Facebook.Controllers" }
            );

            routes.MapRoute("Plugin.ExternalAuth.Facebook.LoginCallback",
                 "Plugins/ExternalAuthFacebook/LoginCallback",
                 new { controller = "ExternalAuthFacebook", action = "LoginCallback" },
                 new[] { "Chj.Plugin.ExternalAuth.Facebook.Controllers" }
            );
        }
        public int Priority
        {
            get
            {
                return 0;
            }
        }
    }
}
