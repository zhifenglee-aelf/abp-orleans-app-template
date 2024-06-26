using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpOrleansAppTemplate.Data;

/* This is used if database provider does't define
 * IAbpOrleansAppTemplateDbSchemaMigrator implementation.
 */
public class NullAbpOrleansAppTemplateDbSchemaMigrator : IAbpOrleansAppTemplateDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
