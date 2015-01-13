using FluentValidation;
using Chj.Core.Domain.Customers;
using Chj.Services.Localization;
using Chj.Web.Framework.Validators;
using Chj.Web.Models.Customer;

namespace Chj.Web.Validators.Customer
{
    public class LoginValidator : BaseNopValidator<LoginModel>
    {
        public LoginValidator(ILocalizationService localizationService, CustomerSettings customerSettings)
        {
            if (!customerSettings.UsernamesEnabled)
            {
                //login by email
                RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("Account.Login.Fields.Email.Required"));
                RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Common.WrongEmail"));
            }
        }
    }
}