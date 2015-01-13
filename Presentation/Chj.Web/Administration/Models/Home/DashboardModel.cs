using Chj.Web.Framework.Mvc;

namespace Chj.Admin.Models.Home
{
    public partial class DashboardModel : BaseNopModel
    {
        public bool IsLoggedInAsVendor { get; set; }
    }
}