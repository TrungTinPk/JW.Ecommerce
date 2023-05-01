﻿using JW.Ecommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace JW.Ecommerce.Admin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EcommerceAdminController : AbpControllerBase
{
    protected EcommerceAdminController()
    {
        LocalizationResource = typeof(EcommerceResource);
    }
}
