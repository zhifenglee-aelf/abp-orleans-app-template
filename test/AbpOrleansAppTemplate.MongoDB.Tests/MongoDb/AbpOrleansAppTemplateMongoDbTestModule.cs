using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace AbpOrleansAppTemplate.MongoDB;

[DependsOn(
    typeof(AbpOrleansAppTemplateApplicationTestModule),
    typeof(AbpOrleansAppTemplateMongoDbModule)
)]
public class AbpOrleansAppTemplateMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = AbpOrleansAppTemplateMongoDbFixture.GetRandomConnectionString();
        });
    }
}
