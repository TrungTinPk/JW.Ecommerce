using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JW.Ecommerce.Products;

public class ProductLinkConfiguration : IEntityTypeConfiguration<ProductLink>
{
    public void Configure(EntityTypeBuilder<ProductLink> builder)
    {
        builder.ToTable(EcommerceConsts.DbTablePrefix + "ProductLinks");
        builder.HasKey(x => new { x.ProductId, x.LinkedProductId });
    }
}