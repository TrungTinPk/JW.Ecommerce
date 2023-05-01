using System;
using System.Collections.Generic;
using System.Text;
using JW.Ecommerce.Localization;
using Volo.Abp.Application.Services;

namespace JW.Ecommerce.Admin;

/* Inherit your application services from this class.
 */
public abstract class EcommerceAdminAppService : ApplicationService
{
    protected EcommerceAdminAppService()
    {
        LocalizationResource = typeof(EcommerceResource);
    }
}
