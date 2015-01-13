using FluentValidation;
using Chj.Services.Localization;
using Chj.Web.Framework.Validators;
using Chj.Web.Models.Boards;

namespace Chj.Web.Validators.Boards
{
    public class EditForumPostValidator : BaseNopValidator<EditForumPostModel>
    {
        public EditForumPostValidator(ILocalizationService localizationService)
        {            
            RuleFor(x => x.Text).NotEmpty().WithMessage(localizationService.GetResource("Forum.TextCannotBeEmpty"));
        }
    }
}