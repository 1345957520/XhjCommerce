using FluentValidation;
using Chj.Services.Localization;
using Chj.Web.Framework.Validators;
using Chj.Web.Models.Customer;

namespace Chj.Web.Validators.Customer
{
    public class PasswordRecoveryValidator : BaseNopValidator<PasswordRecoveryModel>
    {
        public PasswordRecoveryValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("Account.PasswordRecovery.Email.Required"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Common.WrongEmail"));
        }}
}