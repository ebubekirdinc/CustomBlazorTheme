using Volo.Abp.Settings;

namespace CustomBlazorTheme.Settings
{
    public class CustomBlazorThemeSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(CustomBlazorThemeSettings.MySetting1));
        }
    }
}
