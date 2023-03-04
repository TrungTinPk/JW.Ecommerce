using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JW.Ecommerce.Products;

public class ProductAttributeDecimalConfiguration : IEntityTypeConfiguration<ProductAttributeDecimal>
{
    public void Configure(EntityTypeBuilder<ProductAttributeDecimal> builder)
    {
        builder.ToTable(EcommerceConsts.DbTablePrefix + "ProductAttributeDecimals");
        builder.HasKey(x => x.Id);
    }
}