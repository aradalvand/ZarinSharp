using Microsoft.Extensions.DependencyInjection;
using System;

namespace ZarinSharp.Extensions
{
    public static class ZarinSharpServiceCollectionExtensions
    {
        public static IServiceCollection AddZarinSharp(this IServiceCollection services, Action<ZarinSharpOptions> configureOptions = null)
        {
            ZarinSharpOptions options = new();
            configureOptions?.Invoke(options);
            services.AddSingleton(options);
            services.AddHttpClient<ZarinPalService>();
            return services;
        }
    }
}
