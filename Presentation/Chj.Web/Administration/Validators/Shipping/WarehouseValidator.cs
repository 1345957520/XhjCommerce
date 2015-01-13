using FluentValidation;
using Chj.Admin.Models.Shipping;
using Chj.Services.Localization;
using Chj.Web.Framework.Validators;

namespace Chj.Admin.Validators.Shipping
{
    public class WarehouseValidator : BaseNopValidator<WarehouseModel>
    {
        public WarehouseValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Shipping.Warehouses.Fields.Name.Required"));
        }
    }
}