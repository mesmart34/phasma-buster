using PhasmaBuster.Common;
using PhasmaBuster.Contracts;
using PhasmaBuster.Services;
using Radzen;

namespace PhasmaBuster;

internal static class ConfigureServices
{
    internal static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddLocalization();
        services.AddRadzenComponents();
        services.AddSingleton<PhasmaSignsProvider>();
        services.AddSingleton<IApplicationContext, ApplicationContext>();
        
        return services;
    }
}