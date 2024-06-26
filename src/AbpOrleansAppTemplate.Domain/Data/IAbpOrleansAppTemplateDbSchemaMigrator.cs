using System.Threading.Tasks;

namespace AbpOrleansAppTemplate.Data;

public interface IAbpOrleansAppTemplateDbSchemaMigrator
{
    Task MigrateAsync();
}
