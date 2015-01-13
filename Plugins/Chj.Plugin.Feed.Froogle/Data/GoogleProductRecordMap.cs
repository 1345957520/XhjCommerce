using Chj.Data.Mapping;
using Chj.Plugin.Feed.Froogle.Domain;

namespace Chj.Plugin.Feed.Froogle.Data
{
    public partial class GoogleProductRecordMap : NopEntityTypeConfiguration<GoogleProductRecord>
    {
        public GoogleProductRecordMap()
        {
            this.ToTable("GoogleProduct");
            this.HasKey(x => x.Id);
        }
    }
}