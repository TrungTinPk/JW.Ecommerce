using Volo.Abp.Modularity;

namespace JW.Ecommerce.Admin;

[DependsOn(
    typeof(EcommerceApplicationModule),
    typeof(EcommerceDomainTestModule)
    )]
public class EcommerceApplicationTestModule : AbpModule
{

}
