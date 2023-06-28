using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailResaleApi.Data.Entities;

namespace RetailResaleApi.Data.Mapping
{
    public class CostsMapping : BaseEntityMapping<Costs>
    {
        public override void Configure(EntityTypeBuilder<Costs> builder)
        {
            base.Configure(builder);
        }
    }
}
