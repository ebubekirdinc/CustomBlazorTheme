using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CustomBlazorTheme.Data;
using Volo.Abp.DependencyInjection;

namespace CustomBlazorTheme.EntityFrameworkCore
{
    public class EntityFrameworkCoreCustomBlazorThemeDbSchemaMigrator
        : ICustomBlazorThemeDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreCustomBlazorThemeDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the CustomBlazorThemeMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<CustomBlazorThemeMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}