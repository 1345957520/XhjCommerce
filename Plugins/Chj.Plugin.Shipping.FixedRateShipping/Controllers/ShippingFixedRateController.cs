using System.Collections.Generic;
using System.Web.Mvc;
using Chj.Core;
using Chj.Plugin.Shipping.FixedRateShipping.Models;
using Chj.Services.Configuration;
using Chj.Services.Security;
using Chj.Services.Shipping;
using Chj.Web.Framework.Controllers;
using Chj.Web.Framework.Kendoui;
using Chj.Web.Framework.Mvc;

namespace Chj.Plugin.Shipping.FixedRateShipping.Controllers
{
    [AdminAuthorize]
    public class ShippingFixedRateController : BasePluginController
    {
        private readonly IShippingService _shippingService;
        private readonly ISettingService _settingService;
        private readonly IPermissionService _permissionService;

        public ShippingFixedRateController(IShippingService shippingServicee,
            ISettingService settingService, 
            IPermissionService permissionService)
        {
            this._shippingService = shippingServicee;
            this._settingService = settingService;
            this._permissionService = permissionService;
        }
        
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            //little hack here
            //always set culture to 'en-US' (Telerik has a bug related to editing decimal values in other cultures). Like currently it's done for admin area in Global.asax.cs
            CommonHelper.SetTelerikCulture();

            base.Initialize(requestContext);
        }

        [ChildActionOnly]
        public ActionResult Configure()
        {
            return View("~/Plugins/Shipping.FixedRateShipping/Views/ShippingFixedRate/Configure.cshtml");
        }

        [HttpPost]
        public ActionResult Configure(DataSourceRequest command)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageShippingSettings))
                return Content("Access denied");

            var rateModels = new List<FixedShippingRateModel>();
            foreach (var shippingMethod in _shippingService.GetAllShippingMethods())
                rateModels.Add(new FixedShippingRateModel
                {
                    ShippingMethodId = shippingMethod.Id,
                    ShippingMethodName = shippingMethod.Name,
                    Rate = GetShippingRate(shippingMethod.Id)
                });

            var gridModel = new DataSourceResult
            {
                Data = rateModels,
                Total = rateModels.Count
            };
            return Json(gridModel);
        }

        [HttpPost]
        public ActionResult ShippingRateUpdate(FixedShippingRateModel model)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageShippingSettings))
                return Content("Access denied");

            int shippingMethodId = model.ShippingMethodId;
            decimal rate = model.Rate;

            _settingService.SetSetting(string.Format("ShippingRateComputationMethod.FixedRate.Rate.ShippingMethodId{0}", shippingMethodId), rate);

            return new NullJsonResult();
        }

        [NonAction]
        protected decimal GetShippingRate(int shippingMethodId)
        {
            var rate = this._settingService.GetSettingByKey<decimal>(string.Format("ShippingRateComputationMethod.FixedRate.Rate.ShippingMethodId{0}", shippingMethodId));
            return rate;
        }
    }
}
