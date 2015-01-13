using FluentValidation;
using Chj.Admin.Models.Customers;
using Chj.Services.Localization;
using Chj.Web.Framework.Validators;

namespace Chj.Admin.Validators.Customers
{
    public class CustomerRoleValidator : BaseNopValidator<CustomerRoleModel>
    {
        public CustomerRoleValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Customers.CustomerRoles.Fields.Name.Required"));
        }
    }
}