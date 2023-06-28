using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailResaleApi.Data.Entities;

namespace RetailResaleApi.Data.Mapping
{
    public class ListingSiteProductMapping : BaseEntityMapping<ListingSiteProduct>
    {
        public override void Configure(EntityTypeBuilder<ListingSiteProduct> builder)
        {
            builder.HasOne(p => p.Product).WithMany(p => p.ListingSiteProducts).HasForeignKey(k => k.ProductId);
            builder.HasOne(p => p.ListingSite).WithMany(p => p.ListingSiteProducts).HasForeignKey(k => k.ListingSiteId);
            builder.Property(p => p.UrlToListing).HasMaxLength(1000);

            base.Configure(builder);
        }
    }
}
