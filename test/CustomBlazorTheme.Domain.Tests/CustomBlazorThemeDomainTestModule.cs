using CustomBlazorTheme.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CustomBlazorTheme
{
    [DependsOn(
        typeof(CustomBlazorThemeEntityFrameworkCoreTestModule)
        )]
    public class CustomBlazorThemeDomainTestModule : AbpModule
    {

    }
}