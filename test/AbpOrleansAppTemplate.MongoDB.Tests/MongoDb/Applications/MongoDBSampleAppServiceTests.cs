using AbpOrleansAppTemplate.MongoDB;
using AbpOrleansAppTemplate.Samples;
using Xunit;

namespace AbpOrleansAppTemplate.MongoDb.Applications;

[Collection(AbpOrleansAppTemplateTestConsts.CollectionDefinitionName)]
public class MongoDBSampleAppServiceTests : SampleAppServiceTests<AbpOrleansAppTemplateMongoDbTestModule>
{

}
