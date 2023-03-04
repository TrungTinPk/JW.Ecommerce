using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JW.Ecommerce.Promotions;

public class PromotionManufacturerConfiguration : IEntityTypeConfiguration<PromotionManufacturer>
{
    public void Configure(EntityTypeBuilder<PromotionManufacturer> builder)
    {
        builder.ToTable(EcommerceConsts.DbTablePrefix + "PromotionManufacturers");
        builder.HasKey(x => x.Id);
    }
}