using FluentValidation;
using Chj.Services.Localization;
using Chj.Web.Framework.Validators;
using Chj.Web.Models.PrivateMessages;

namespace Chj.Web.Validators.PrivateMessages
{
    public class SendPrivateMessageValidator : BaseNopValidator<SendPrivateMessageModel>
    {
        public SendPrivateMessageValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Subject).NotEmpty().WithMessage(localizationService.GetResource("PrivateMessages.SubjectCannotBeEmpty"));
            RuleFor(x => x.Message).NotEmpty().WithMessage(localizationService.GetResource("PrivateMessages.MessageCannotBeEmpty"));
        }
    }
}