using AbpOrleansAppTemplate.Samples;
using Xunit;

namespace AbpOrleansAppTemplate.MongoDB.Domains;

[Collection(AbpOrleansAppTemplateTestConsts.CollectionDefinitionName)]
public class MongoDBSampleDomainTests : SampleDomainTests<AbpOrleansAppTemplateMongoDbTestModule>
{

}
