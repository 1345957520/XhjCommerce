using FluentValidation;
using Chj.Admin.Models.Messages;
using Chj.Services.Localization;
using Chj.Web.Framework.Validators;

namespace Chj.Admin.Validators.Messages
{
    public class EmailAccountValidator : BaseNopValidator<EmailAccountModel>
    {
        public EmailAccountValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Admin.Common.WrongEmail"));
            
            RuleFor(x => x.DisplayName).NotEmpty();
        }
    }
}