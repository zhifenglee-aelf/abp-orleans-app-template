using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpOrleansAppTemplate;

[Dependency(ReplaceServices = true)]
public class AbpOrleansAppTemplateBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpOrleansAppTemplate";
}
