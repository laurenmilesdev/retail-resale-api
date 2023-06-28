using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailResaleApi.Data.Entities;

namespace RetailResaleApi.Data.Mapping
{
    public class CategoryMapping : BaseEntityMapping<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new
                {
                    Id = 1,
                    Value = "Accessories"
                },
                new
                {
                    Id = 2,
                    Value = "Dresses"
                },
                new
                {
                    Id = 3,
                    Value = "Jackets/Coats"
                },
                new
                {
                    Id = 4,
                    Value = "Jeans"
                },
                new
                {
                    Id = 5,
                    Value = "Pants"
                },
                new
                {
                    Id = 6,
                    Value = "Shirts/Tops"
                },
                new
                {
                    Id = 7,
                    Value = "Shoes"
                },
                new
                {
                    Id = 8,
                    Value = "Shorts"
                },
                new
                {
                    Id = 9,
                    Value = "Skirts"
                },
                new
                {
                    Id = 10,
                    Value = "Sweaters"
                },
                new
                {
                    Id = 11,
                    Value = "Other"
                });

            base.Configure(builder);
        }
    }
}
