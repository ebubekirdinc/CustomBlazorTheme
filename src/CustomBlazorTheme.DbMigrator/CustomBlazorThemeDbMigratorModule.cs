using CustomBlazorTheme.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace CustomBlazorTheme.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(CustomBlazorThemeEntityFrameworkCoreDbMigrationsModule),
        typeof(CustomBlazorThemeApplicationContractsModule)
        )]
    public class CustomBlazorThemeDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
