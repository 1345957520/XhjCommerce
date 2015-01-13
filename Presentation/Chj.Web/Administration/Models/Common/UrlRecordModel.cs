using System.Web.Mvc;
using Chj.Web.Framework;
using Chj.Web.Framework.Mvc;

namespace Chj.Admin.Models.Common
{
    public partial class UrlRecordModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Admin.System.SeNames.Name")]
        [AllowHtml]
        public string Name { get; set; }

        [NopResourceDisplayName("Admin.System.SeNames.EntityId")]
        public int EntityId { get; set; }

        [NopResourceDisplayName("Admin.System.SeNames.EntityName")]
        public string EntityName { get; set; }

        [NopResourceDisplayName("Admin.System.SeNames.IsActive")]
        public bool IsActive { get; set; }

        [NopResourceDisplayName("Admin.System.SeNames.Language")]
        public string Language { get; set; }
    }
}