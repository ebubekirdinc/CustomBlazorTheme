using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace CustomBlazorTheme.EntityFrameworkCore
{
    [DependsOn(
        typeof(CustomBlazorThemeEntityFrameworkCoreModule)
        )]
    public class CustomBlazorThemeEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<CustomBlazorThemeMigrationsDbContext>();
        }
    }
}
