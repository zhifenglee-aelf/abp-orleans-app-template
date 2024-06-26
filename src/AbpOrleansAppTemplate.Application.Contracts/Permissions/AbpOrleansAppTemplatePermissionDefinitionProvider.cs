using AbpOrleansAppTemplate.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpOrleansAppTemplate.Permissions;

public class AbpOrleansAppTemplatePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpOrleansAppTemplatePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpOrleansAppTemplatePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpOrleansAppTemplateResource>(name);
    }
}
