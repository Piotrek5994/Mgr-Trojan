using Optima_Symulator.Models.Settings;

namespace Optima_Symulator.Configurations;

public static class JsonManagerConfig
{
    public static void ConfigureJsonSettings(IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<JsonSetting>(configuration.GetSection("JsonSettings"));
    }
}
