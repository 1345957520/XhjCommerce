using FluentValidation;
using Chj.Services.Localization;
using Chj.Web.Framework.Validators;
using Chj.Web.Models.Blogs;

namespace Chj.Web.Validators.Blogs
{
    public class BlogPostValidator : BaseNopValidator<BlogPostModel>
    {
        public BlogPostValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.AddNewComment.CommentText).NotEmpty().WithMessage(localizationService.GetResource("Blog.Comments.CommentText.Required")).When(x => x.AddNewComment != null);
        }}
}