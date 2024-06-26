using AbpOrleansAppTemplate.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.Caching;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.Modularity;

namespace AbpOrleansAppTemplate.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpCachingStackExchangeRedisModule),
    typeof(AbpOrleansAppTemplateMongoDbModule),
    typeof(AbpOrleansAppTemplateApplicationContractsModule)
    )]
public class AbpOrleansAppTemplateDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDistributedCacheOptions>(options => { options.KeyPrefix = "AbpOrleansAppTemplate:"; });
    }
}
