using System;
using System.Collections.Generic;
using System.Text;
using AbpOrleansAppTemplate.Localization;
using Volo.Abp.Application.Services;

namespace AbpOrleansAppTemplate;

/* Inherit your application services from this class.
 */
public abstract class AbpOrleansAppTemplateAppService : ApplicationService
{
    protected AbpOrleansAppTemplateAppService()
    {
        LocalizationResource = typeof(AbpOrleansAppTemplateResource);
    }
}
