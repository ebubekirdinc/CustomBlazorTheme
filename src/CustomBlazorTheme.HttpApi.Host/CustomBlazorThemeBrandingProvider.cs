using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace CustomBlazorTheme
{
    [Dependency(ReplaceServices = true)]
    public class CustomBlazorThemeBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "CustomBlazorTheme";
    }
}
