using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace JW.Ecommerce.ProductCategories
{
    public interface IProductCategoriesAppService: ICrudAppService<
        ProductCategoryDto,
        Guid, 
        PagedResultRequestDto,
        CreateUpdateProductRequestDto,
        CreateUpdateProductRequestDto
        >
    {
    }
}
