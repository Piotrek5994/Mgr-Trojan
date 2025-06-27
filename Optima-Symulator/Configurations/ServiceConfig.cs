using Optima_Symulator.Services;
using Optima_Symulator.Services.Interfaces;

namespace Optima_Symulator.Configurations;

public static class ServiceConfig
{
    public static IServiceCollection AddProjectService(IServiceCollection services)
    {
        services.AddScoped<IAuthorizationService, AuthorizationService>();
        services.AddScoped<IContractorService, ContractorService>();
        services.AddScoped<IDocumentService, DocumentService>();

        return services;
    }
}
