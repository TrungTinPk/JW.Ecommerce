using System;
using System.Collections.Generic;
using System.Text;
using JW.Ecommerce.Localization;
using Volo.Abp.Application.Services;

namespace JW.Ecommerce;

/* Inherit your application services from this class.
 */
public abstract class EcommerceAppService : ApplicationService
{
    protected EcommerceAppService()
    {
        LocalizationResource = typeof(EcommerceResource);
    }
}
