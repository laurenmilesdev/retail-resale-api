using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailResaleApi.Data.Entities;

namespace RetailResaleApi.Data.Mapping
{
    public class SoldMapping : BaseEntityMapping<Sold>
    {
        public override void Configure(EntityTypeBuilder<Sold> builder)
        {
            base.Configure(builder);
        }
    }
}
