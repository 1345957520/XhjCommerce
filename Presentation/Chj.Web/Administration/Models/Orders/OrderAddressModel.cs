using Chj.Admin.Models.Common;
using Chj.Web.Framework.Mvc;

namespace Chj.Admin.Models.Orders
{
    public partial class OrderAddressModel : BaseNopModel
    {
        public int OrderId { get; set; }

        public AddressModel Address { get; set; }
    }
}