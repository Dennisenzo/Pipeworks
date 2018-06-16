using Denga.Pipeworks.Data;
using Denga.Pipeworks.SiteSettings.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Denga.Pipeworks.SiteSettings
{
    public static class StartupExtensions
    {
        public static void AddSettings(this IPlumber plumber)
        {
          plumber.AddDatabase<SiteSettingsContext>();

        }
    }

    public enum DatabaseType
    {
        MsSql,
        MySql,
        MySqlDevart
    }
}