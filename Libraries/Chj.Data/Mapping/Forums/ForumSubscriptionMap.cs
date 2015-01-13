using Chj.Core.Domain.Forums;

namespace Chj.Data.Mapping.Forums
{
    public partial class ForumSubscriptionMap : NopEntityTypeConfiguration<ForumSubscription>
    {
        public ForumSubscriptionMap()
        {
            this.ToTable("Forums_Subscription");
            this.HasKey(fs => fs.Id);

            this.HasRequired(fs => fs.Customer)
                .WithMany()
                .HasForeignKey(fs => fs.CustomerId)
                .WillCascadeOnDelete(false);
        }
    }
}
