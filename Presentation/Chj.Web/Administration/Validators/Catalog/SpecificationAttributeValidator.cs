using FluentValidation;
using Chj.Admin.Models.Catalog;
using Chj.Services.Localization;
using Chj.Web.Framework.Validators;

namespace Chj.Admin.Validators.Catalog
{
    public class SpecificationAttributeValidator : BaseNopValidator<SpecificationAttributeModel>
    {
        public SpecificationAttributeValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.Attributes.SpecificationAttributes.Fields.Name.Required"));
        }
    }
}