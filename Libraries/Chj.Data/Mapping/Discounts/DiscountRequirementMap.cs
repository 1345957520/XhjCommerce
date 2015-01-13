using Chj.Core.Domain.Discounts;

namespace Chj.Data.Mapping.Discounts
{
    public partial class DiscountRequirementMap : NopEntityTypeConfiguration<DiscountRequirement>
    {
        public DiscountRequirementMap()
        {
            this.ToTable("DiscountRequirement");
            this.HasKey(dr => dr.Id);
        }
    }
}