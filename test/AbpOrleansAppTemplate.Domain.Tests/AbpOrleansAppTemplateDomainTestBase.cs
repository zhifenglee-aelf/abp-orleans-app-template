using Volo.Abp.Modularity;

namespace AbpOrleansAppTemplate;

/* Inherit from this class for your domain layer tests. */
public abstract class AbpOrleansAppTemplateDomainTestBase<TStartupModule> : AbpOrleansAppTemplateTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
