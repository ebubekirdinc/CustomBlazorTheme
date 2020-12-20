using Volo.Abp.Bundling;

namespace CustomBlazorTheme.Blazor
{
    public class CustomBlazorThemeBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {
        }

        public void AddStyles(BundleContext context)
        {
            context.Add("main.css");
        }
    }
}
