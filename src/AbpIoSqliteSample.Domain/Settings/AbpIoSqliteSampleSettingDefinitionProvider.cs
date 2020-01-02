using Volo.Abp.Settings;

namespace AbpIoSqliteSample.Settings
{
    public class AbpIoSqliteSampleSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpIoSqliteSampleSettings.MySetting1));
        }
    }
}
