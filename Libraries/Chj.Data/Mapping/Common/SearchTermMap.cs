using Chj.Core.Domain.Common;

namespace Chj.Data.Mapping.Common
{
    public partial class SearchTermMap : NopEntityTypeConfiguration<SearchTerm>
    {
        public SearchTermMap()
        {
            this.ToTable("SearchTerm");
            this.HasKey(st => st.Id);
        }
    }
}
