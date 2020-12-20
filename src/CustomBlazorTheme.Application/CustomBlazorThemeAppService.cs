using System;
using System.Collections.Generic;
using System.Text;
using CustomBlazorTheme.Localization;
using Volo.Abp.Application.Services;

namespace CustomBlazorTheme
{
    /* Inherit your application services from this class.
     */
    public abstract class CustomBlazorThemeAppService : ApplicationService
    {
        protected CustomBlazorThemeAppService()
        {
            LocalizationResource = typeof(CustomBlazorThemeResource);
        }
    }
}
