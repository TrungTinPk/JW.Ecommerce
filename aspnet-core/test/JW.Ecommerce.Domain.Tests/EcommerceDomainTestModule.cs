using JW.Ecommerce.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace JW.Ecommerce;

[DependsOn(
    typeof(EcommerceEntityFrameworkCoreTestModule)
    )]
public class EcommerceDomainTestModule : AbpModule
{

}
