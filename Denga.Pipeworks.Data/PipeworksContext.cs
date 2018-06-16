using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Denga.Pipeworks.Data
{
    public abstract class PipeworksContext<T> : DbContext where T:DbContext
    {
        protected PipeworksContext(DbContextOptions<T> settings) : base(settings) 
        {
          
        }

        public class ContextSettings
        {

            public string MigrationsAssembly { get; internal set; } = Assembly.GetCallingAssembly().FullName;

        }
    }
}
