﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JW.Ecommerce.Products;

namespace JW.Ecommerce.Configurations.Products
{
    public class ProductLinkConfiguration : IEntityTypeConfiguration<ProductLink>
    {
        public void Configure(EntityTypeBuilder<ProductLink> builder)
        {
            builder.ToTable(EcommerceConsts.DbTablePrefix + "ProductLinks");
            builder.HasKey(x => new { x.ProductId, x.LinkedProductId });
        }
    }
}
