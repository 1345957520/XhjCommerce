using System.Web.Mvc;
using System.Web.Routing;
using Chj.Web.Framework.Mvc.Routes;

namespace Chj.Plugin.DiscountRules.HadSpentAmount
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Plugin.DiscountRules.HadSpentAmount.Configure",
                 "Plugins/DiscountRulesHadSpentAmount/Configure",
                 new { controller = "DiscountRulesHadSpentAmount", action = "Configure" },
                 new[] { "Chj.Plugin.DiscountRules.HadSpentAmount.Controllers" }
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
