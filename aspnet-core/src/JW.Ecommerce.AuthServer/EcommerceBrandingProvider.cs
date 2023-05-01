using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace JW.Ecommerce;

[Dependency(ReplaceServices = true)]
public class EcommerceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Ecommerce";
}
