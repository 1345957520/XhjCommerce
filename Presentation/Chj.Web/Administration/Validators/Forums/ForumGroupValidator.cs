using FluentValidation;
using Chj.Admin.Models.Forums;
using Chj.Services.Localization;
using Chj.Web.Framework.Validators;

namespace Chj.Admin.Validators.Forums
{
    public class ForumGroupValidator : BaseNopValidator<ForumGroupModel>
    {
        public ForumGroupValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.ContentManagement.Forums.ForumGroup.Fields.Name.Required"));
        }
    }
}