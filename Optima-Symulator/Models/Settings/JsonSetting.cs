namespace Optima_Symulator.Models.Settings;

public class JsonSetting
{
    public string JwtKey { get; set; } = string.Empty;
    public int TokenExpirationHours { get; set; } = 24;
    public string Issuer { get; set; } = "Optima";
    public string Audience { get; set; } = "OptimaUsers";
}
