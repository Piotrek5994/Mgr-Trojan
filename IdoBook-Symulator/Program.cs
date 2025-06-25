using IdoBook_Symulator.Configurations;

namespace IdoBook_Symulator;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        JsonManagerConfig.ConfigureJsonSettings(builder.Services, builder.Configuration);

        ServiceConfig.AddProjectService(builder.Services);
        SwaggerConfig.ConfigureSwagger(builder);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();

        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowAll", policy =>
            {
                policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            });
        });

        builder.Services.AddJwtAuthentication(builder.Configuration);

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            SwaggerConfig.UseSwaggerUI(app);
        }
        else
        {
            SwaggerConfig.UseSwaggerUI(app);
        }

        app.UseCors("AllowAll");

        app.UseHttpsRedirection();
        
        app.UseAuthentication();
        app.UseAuthorization();
        
        app.MapControllers();

        app.Run();
    }
}
