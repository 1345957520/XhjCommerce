using Chj.Core.Domain.Catalog;

namespace Chj.Data.Mapping.Catalog
{
    public partial class RelatedProductMap : NopEntityTypeConfiguration<RelatedProduct>
    {
        public RelatedProductMap()
        {
            this.ToTable("RelatedProduct");
            this.HasKey(c => c.Id);
        }
    }
}