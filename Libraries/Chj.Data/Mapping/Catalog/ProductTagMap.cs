using Chj.Core.Domain.Catalog;

namespace Chj.Data.Mapping.Catalog
{
    public partial class ProductTagMap : NopEntityTypeConfiguration<ProductTag>
    {
        public ProductTagMap()
        {
            this.ToTable("ProductTag");
            this.HasKey(pt => pt.Id);
            this.Property(pt => pt.Name).IsRequired().HasMaxLength(400);
        }
    }
}