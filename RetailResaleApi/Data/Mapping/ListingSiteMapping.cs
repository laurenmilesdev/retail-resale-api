using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailResaleApi.Data.Entities;

namespace RetailResaleApi.Data.Mapping
{
    public class ListingSiteMapping : BaseEntityMapping<ListingSite>
    {
        public override void Configure(EntityTypeBuilder<ListingSite> builder)
        {
            builder.Property(p => p.SiteName).HasMaxLength(100);
            builder.Property(p => p.Url).HasMaxLength(1000);

            base.Configure(builder);
        }
    }
}
