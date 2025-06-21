using IdoBook_Symulator.Models.Settings;

namespace IdoBook_Symulator.Configurations;

public static class JsonManagerConfig
{
    public static void ConfigureJsonSettings(IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<JsonSetting>(configuration.GetSection("JsonSettings"));
    }
}
