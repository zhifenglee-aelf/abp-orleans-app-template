using Volo.Abp.Modularity;

namespace AbpOrleansAppTemplate;

[DependsOn(
    typeof(AbpOrleansAppTemplateApplicationModule),
    typeof(AbpOrleansAppTemplateDomainTestModule)
)]
public class AbpOrleansAppTemplateApplicationTestModule : AbpModule
{

}
