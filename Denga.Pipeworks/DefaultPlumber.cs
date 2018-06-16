using System;
using Microsoft.Extensions.DependencyInjection;

namespace Denga.Pipeworks
{
    internal class DefaultPlumber : IPlumber
    {
        public IServiceCollection Services { get; private set; }
        public string ConnectionString { get; set; }

        public DefaultPlumber(IServiceCollection services)
        {
            Services = services;
        } 
    }
}
