using CustomBlazorTheme.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CustomBlazorTheme.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class CustomBlazorThemeController : AbpController
    {
        protected CustomBlazorThemeController()
        {
            LocalizationResource = typeof(CustomBlazorThemeResource);
        }
    }
}