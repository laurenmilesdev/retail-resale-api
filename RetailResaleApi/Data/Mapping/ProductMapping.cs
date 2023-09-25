using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailResaleApi.Data.Entities;

namespace RetailResaleApi.Data.Mapping
{
    public class ProductMapping : BaseEntityMapping<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.IsSold).HasDefaultValue(false);
            builder.Property(p => p.SizeType).HasConversion<int>();
            builder.Property(p => p.Name).HasMaxLength(50);
            builder.Property(p => p.Description).HasMaxLength(250);
            builder.Property(p => p.Size).HasMaxLength(10);
            builder.Property(p => p.Brand).HasMaxLength(50);

            base.Configure(builder);
        }
    }
}
