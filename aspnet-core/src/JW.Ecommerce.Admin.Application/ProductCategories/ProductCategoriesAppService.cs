﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace JW.Ecommerce.ProductCategories
{
    public class ProductCategoriesAppService: 
        CrudAppService<ProductCategory,ProductCategoryDto,Guid,PagedResultRequestDto,CreateUpdateProductRequestDto,CreateUpdateProductRequestDto>,
        IProductCategoriesAppService
    {
        public ProductCategoriesAppService(IRepository<ProductCategory,Guid> repository): base(repository)
        {
            
        }
    }
}
