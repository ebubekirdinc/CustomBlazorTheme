using System.Threading.Tasks;

namespace CustomBlazorTheme.Data
{
    public interface ICustomBlazorThemeDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
