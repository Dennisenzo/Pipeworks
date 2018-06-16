using System;
using Denga.Pipeworks.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Denga.Pipeworks.HttpCommunication
{
    public static class StartupExtensions
    {
        public static void AddViewsEngine(this IPlumber plumber, Action<IViewsEngineSettings> viewsEngineSettings)
        {


            var settings = new BaseViewsEngineSettings();

            viewsEngineSettings.Invoke(settings);

            AddDependencies(plumber.Services, settings);
        }

        private static void AddDependencies(IServiceCollection services,IViewsEngineSettings settings)
        {
            services.AddScoped<IViewsEngine, BaseViewsEngine>();
            services.AddSingleton<IViewsEngineSettings>(settings);
        }
    }
}
