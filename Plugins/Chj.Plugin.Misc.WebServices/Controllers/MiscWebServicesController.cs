using System.Web.Mvc;
using Chj.Web.Framework.Controllers;

namespace Chj.Plugin.Misc.WebServices.Controllers
{
    [AdminAuthorize]
    public class MiscWebServicesController : BasePluginController
    {
        public ActionResult Configure()
        {
            return View("~/Plugins/Misc.WebServices/Views/MiscWebServices/Configure.cshtml");
        }
    }
}
