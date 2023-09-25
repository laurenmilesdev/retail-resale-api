using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailResaleApi.Data.Entities;

namespace RetailResaleApi.Data.Mapping
{
    public class ConditionMapping : BaseEntityMapping<Condition>
    {
        public override void Configure(EntityTypeBuilder<Condition> builder)
        {
            builder.HasData(
                new
                {
                    Id = 1,
                    Value = "Brand New"
                },
                new
                {
                    Id = 2,
                    Value = "Like New"
                },
                new
                {
                    Id = 3,
                    Value = "Used - Excellent"
                },
                new
                {
                    Id = 4,
                    Value = "Used - Good"
                },
                new
                {
                    Id = 5,
                    Value = "Used - Fair"
                });

            base.Configure(builder);
        }
    }
}
