using CustomBlazorTheme.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CustomBlazorTheme.Permissions
{
    public class CustomBlazorThemePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(CustomBlazorThemePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(CustomBlazorThemePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<CustomBlazorThemeResource>(name);
        }
    }
}
