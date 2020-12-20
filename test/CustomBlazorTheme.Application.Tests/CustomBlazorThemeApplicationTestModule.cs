using Volo.Abp.Modularity;

namespace CustomBlazorTheme
{
    [DependsOn(
        typeof(CustomBlazorThemeApplicationModule),
        typeof(CustomBlazorThemeDomainTestModule)
        )]
    public class CustomBlazorThemeApplicationTestModule : AbpModule
    {

    }
}