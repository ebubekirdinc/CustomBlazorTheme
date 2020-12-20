using CustomBlazorTheme.Localization;
using Volo.Abp.AspNetCore.Components;

namespace CustomBlazorTheme.Blazor
{
    public abstract class CustomBlazorThemeComponentBase : AbpComponentBase
    {
        protected CustomBlazorThemeComponentBase()
        {
            LocalizationResource = typeof(CustomBlazorThemeResource);
        }
    }
}
