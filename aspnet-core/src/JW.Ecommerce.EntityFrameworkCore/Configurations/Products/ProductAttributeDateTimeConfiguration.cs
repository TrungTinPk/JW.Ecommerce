using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JW.Ecommerce.Products;

public class ProductAttributeDateTimeConfiguration : IEntityTypeConfiguration<ProductAttributeDateTime>
{
    public void Configure(EntityTypeBuilder<ProductAttributeDateTime> builder)
    {
        builder.ToTable(EcommerceConsts.DbTablePrefix + "ProductAttributeDateTimes");
        builder.HasKey(x => x.Id);


           
    }
}