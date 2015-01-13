using FluentValidation;
using Chj.Admin.Models.Catalog;
using Chj.Services.Localization;
using Chj.Web.Framework.Validators;

namespace Chj.Admin.Validators.Catalog
{
    public class ProductAttributeValidator : BaseNopValidator<ProductAttributeModel>
    {
        public ProductAttributeValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.Attributes.ProductAttributes.Fields.Name.Required"));
        }
    }
}