using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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
        Task<PagedResultDto<ProductCategoryInListDto>> GetListFilterAsync(BaseListFilterDto input);
    }
}
