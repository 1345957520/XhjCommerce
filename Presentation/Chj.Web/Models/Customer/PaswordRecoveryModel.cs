using System.Web.Mvc;
using FluentValidation.Attributes;
using Chj.Web.Framework;
using Chj.Web.Framework.Mvc;
using Chj.Web.Validators.Customer;

namespace Chj.Web.Models.Customer
{
    [Validator(typeof(PasswordRecoveryValidator))]
    public partial class PasswordRecoveryModel : BaseNopModel
    {
        [AllowHtml]
        [NopResourceDisplayName("Account.PasswordRecovery.Email")]
        public string Email { get; set; }

        public string Result { get; set; }
    }
}