using Volo.Abp.Modularity;

namespace AbpOrleansAppTemplate;

[DependsOn(
    typeof(AbpOrleansAppTemplateDomainModule),
    typeof(AbpOrleansAppTemplateTestBaseModule)
)]
public class AbpOrleansAppTemplateDomainTestModule : AbpModule
{

}
