using Chj.Web.Framework.Mvc;

namespace Chj.Admin.Models.Security
{
    public partial class PermissionRecordModel : BaseNopModel
    {
        public string Name { get; set; }
        public string SystemName { get; set; }
    }
}