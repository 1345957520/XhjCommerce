using Chj.Data.Mapping;
using Chj.Plugin.Shipping.ByWeight.Domain;

namespace Chj.Plugin.Shipping.ByWeight.Data
{
    public partial class ShippingByWeightRecordMap : NopEntityTypeConfiguration<ShippingByWeightRecord>
    {
        public ShippingByWeightRecordMap()
        {
            this.ToTable("ShippingByWeight");
            this.HasKey(x => x.Id);

            this.Property(x => x.Zip).HasMaxLength(400);
        }
    }
}