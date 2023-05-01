﻿using JW.Ecommerce.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace JW.Ecommerce.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(EcommerceEntityFrameworkCoreModule),
    typeof(EcommerceApplicationContractsModule)
    )]
public class EcommerceDbMigratorModule : AbpModule
{

}
