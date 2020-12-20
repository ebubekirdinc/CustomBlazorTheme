using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CustomBlazorTheme.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class CustomBlazorThemeMigrationsDbContextFactory : IDesignTimeDbContextFactory<CustomBlazorThemeMigrationsDbContext>
    {
        public CustomBlazorThemeMigrationsDbContext CreateDbContext(string[] args)
        {
            CustomBlazorThemeEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<CustomBlazorThemeMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new CustomBlazorThemeMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../CustomBlazorTheme.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
