using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CustomBlazorTheme.Data
{
    /* This is used if database provider does't define
     * ICustomBlazorThemeDbSchemaMigrator implementation.
     */
    public class NullCustomBlazorThemeDbSchemaMigrator : ICustomBlazorThemeDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}