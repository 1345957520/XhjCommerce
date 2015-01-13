using System.Web.Mvc;
using Chj.Web.Framework;
using Chj.Web.Framework.Mvc;

namespace Chj.Admin.Models.Catalog
{
    public partial class ManufacturerListModel : BaseNopModel
    {
        [NopResourceDisplayName("Admin.Catalog.Manufacturers.List.SearchManufacturerName")]
        [AllowHtml]
        public string SearchManufacturerName { get; set; }
    }
}