﻿using IdoBook_Symulator.Services;
using IdoBook_Symulator.Services.Interfaces;

namespace IdoBook_Symulator.Configurations;

public static class ServiceConfig
{
    public static IServiceCollection AddProjectService(IServiceCollection services)
    {
        services.AddScoped<IAuthorizationService, AuthorizationService>();
        services.AddScoped<IClientService, ClientService>();
        services.AddScoped<IReservationsService, ReservationsService>();

        return services;
    }
}
