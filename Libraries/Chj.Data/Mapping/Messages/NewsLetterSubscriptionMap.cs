using Chj.Core.Domain.Messages;

namespace Chj.Data.Mapping.Messages
{
    public partial class NewsLetterSubscriptionMap : NopEntityTypeConfiguration<NewsLetterSubscription>
    {
        public NewsLetterSubscriptionMap()
        {
            this.ToTable("NewsLetterSubscription");
            this.HasKey(nls => nls.Id);

            this.Property(nls => nls.Email).IsRequired().HasMaxLength(255);
        }
    }
}