using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JW.Ecommerce.Products;

public class ProductAttributeTextConfiguration : IEntityTypeConfiguration<ProductAttributeText>
{
    public void Configure(EntityTypeBuilder<ProductAttributeText> builder)
    {
        builder.ToTable(EcommerceConsts.DbTablePrefix + "ProductAttributeTexts");
        builder.HasKey(x => x.Id);
    }
}