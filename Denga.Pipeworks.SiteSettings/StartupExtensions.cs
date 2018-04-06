using Denga.Pipeworks.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Denga.Pipeworks.SiteSettings
{
    public static class StartupExtensions
    {
        public static void AddDatabase<T>(this IPlumber plumber, string connectionString, DatabaseType databaseType = DatabaseType.MsSql, string migrationsAssembly = null) where T:PipeworksContext
        {
           
        }
    }

    public enum DatabaseType
    {
        MsSql,
        MySql,
    MySqlDevart
    }
}