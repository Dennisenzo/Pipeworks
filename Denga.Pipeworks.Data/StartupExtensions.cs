using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Denga.Pipeworks.Data
{
    public static class StartupExtensions
    {
        public static void AddDatabase<T>(this IPlumber plumber, string connectionString = null, DatabaseType databaseType = DatabaseType.MsSql, string migrationsAssembly = null) where T:PipeworksContext<T>
        {
            if (migrationsAssembly == null)
            {
                migrationsAssembly= typeof(T).Assembly.FullName;
            }

            switch (databaseType)
            {
                case DatabaseType.MsSql:

                    {
                        plumber.Services.AddDbContext<T>(options => options.UseSqlServer(
                             connectionString??plumber.ConnectionString,
                              b => b.MigrationsAssembly(migrationsAssembly)));
                        break;
                    }
            }
     
        }
    }

    public enum DatabaseType
    {
        MsSql,
        MySql,
    MySqlDevart
    }
}