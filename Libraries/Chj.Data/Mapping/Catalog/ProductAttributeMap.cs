using Chj.Core.Domain.Catalog;

namespace Chj.Data.Mapping.Catalog
{
    public partial class ProductAttributeMap : NopEntityTypeConfiguration<ProductAttribute>
    {
        public ProductAttributeMap()
        {
            this.ToTable("ProductAttribute");
            this.HasKey(pa => pa.Id);
            this.Property(pa => pa.Name).IsRequired();
        }
    }
}