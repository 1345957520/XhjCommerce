using System.Web.Mvc;
using Chj.Web.Framework;
using Chj.Web.Framework.Mvc;

namespace Chj.Admin.Models.Vendors
{
    public partial class VendorListModel : BaseNopModel
    {
        [NopResourceDisplayName("Admin.Vendors.List.SearchName")]
        [AllowHtml]
        public string SearchName { get; set; }
    }
}