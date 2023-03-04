using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JW.Ecommerce.Products;

public class ProductAttributeIntConfiguration : IEntityTypeConfiguration<ProductAttributeInt>
{
    public void Configure(EntityTypeBuilder<ProductAttributeInt> builder)
    {
        builder.ToTable(EcommerceConsts.DbTablePrefix + "ProductAttributeInts");
        builder.HasKey(x => x.Id);
    }
}