using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Denga.Pipeworks
{
    public static class StartupExtensions
    {
        public static void AddPipeworks(this IServiceCollection services, Action<IPlumber> plumberAction)
        {
            IPlumber plumber = new DefaultPlumber(services);

            plumber.Apply(plumberAction);

        }
        public static void UsePipeworks(this IApplicationBuilder app)
        {
            app.Use(request =>
            {
               return request;
            });
        }
        internal static void Apply(this IPlumber plumber, Action<IPlumber> plumberAction)
        {

        }
    }
}

