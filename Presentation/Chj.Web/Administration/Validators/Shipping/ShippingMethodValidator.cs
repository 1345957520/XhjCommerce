using FluentValidation;
using Chj.Admin.Models.Shipping;
using Chj.Services.Localization;
using Chj.Web.Framework.Validators;

namespace Chj.Admin.Validators.Shipping
{
    public class ShippingMethodValidator : BaseNopValidator<ShippingMethodModel>
    {
        public ShippingMethodValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Shipping.Methods.Fields.Name.Required"));
        }
    }
}