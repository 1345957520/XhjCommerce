using FluentValidation;
using Chj.Admin.Models.Discounts;
using Chj.Services.Localization;
using Chj.Web.Framework.Validators;

namespace Chj.Admin.Validators.Discounts
{
    public class DiscountValidator : BaseNopValidator<DiscountModel>
    {
        public DiscountValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Promotions.Discounts.Fields.Name.Required"));
        }
    }
}