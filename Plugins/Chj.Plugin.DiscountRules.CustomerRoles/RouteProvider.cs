using System.Web.Mvc;
using System.Web.Routing;
using Chj.Web.Framework.Mvc.Routes;

namespace Chj.Plugin.DiscountRules.CustomerRoles
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Plugin.DiscountRules.CustomerRoles.Configure",
                 "Plugins/DiscountRulesCustomerRoles/Configure",
                 new { controller = "DiscountRulesCustomerRoles", action = "Configure" },
                 new[] { "Chj.Plugin.DiscountRules.CustomerRoles.Controllers" }
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
