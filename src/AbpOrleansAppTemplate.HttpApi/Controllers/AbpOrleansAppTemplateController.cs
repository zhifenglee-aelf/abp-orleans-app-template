using AbpOrleansAppTemplate.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpOrleansAppTemplate.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpOrleansAppTemplateController : AbpControllerBase
{
    protected AbpOrleansAppTemplateController()
    {
        LocalizationResource = typeof(AbpOrleansAppTemplateResource);
    }
}
