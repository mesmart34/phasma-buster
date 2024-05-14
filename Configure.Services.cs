using PhasmaBuster.Common;
using Radzen;

namespace PhasmaBuster;

internal static class ConfigureServices
{
    internal static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddLocalization();
        services.AddRadzenComponents();
        services.AddSingleton<PhasmaSignsProvider>();
        
        return services;
    }
}