using AbpIoSqliteSample.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpIoSqliteSample.Permissions
{
    public class AbpIoSqliteSamplePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpIoSqliteSamplePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpIoSqliteSamplePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpIoSqliteSampleResource>(name);
        }
    }
}
