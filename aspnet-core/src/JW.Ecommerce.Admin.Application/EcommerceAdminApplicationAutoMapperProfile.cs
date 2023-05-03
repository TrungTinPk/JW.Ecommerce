using AutoMapper;
using JW.Ecommerce.ProductCategories;

namespace JW.Ecommerce.Admin;

public class EcommerceAdminApplicationAutoMapperProfile : Profile
{
    public EcommerceAdminApplicationAutoMapperProfile()
    {
        CreateMap<ProductCategory, ProductCategoryDto>();
        CreateMap<ProductCategory, ProductCategoryInListDto>();
        CreateMap<CreateUpdateProductRequestDto, ProductCategory>();
    }
}
