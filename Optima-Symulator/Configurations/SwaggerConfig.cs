using Swashbuckle.AspNetCore.SwaggerGen;

namespace Optima_Symulator.Configurations;

public static class SwaggerConfig
{
    public static void ConfigureSwagger(WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerGen(swagger =>
        {
            swagger.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
            {
                Title = "Optima-Simulator",
                Version = "v1",
                Description = "Documentation"
            });

            swagger.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Name = "Authorization",
                Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey,
                Scheme = "Bearer",
                BearerFormat = "JWT",
                In = Microsoft.OpenApi.Models.ParameterLocation.Header,
                Description = "Wpisz **Bearer** i spację, a potem token JWT.\r\nPrzykład: `Bearer eyJhbGciOi...`"
            });

            swagger.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
        {
            {
                new Microsoft.OpenApi.Models.OpenApiSecurityScheme
                {
                    Reference = new Microsoft.OpenApi.Models.OpenApiReference
                    {
                        Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },
                Array.Empty<string>()
            }
        });

            DeclareSwaggerSchema(swagger);
        });
    }


    public static void UseSwaggerUI(WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Optima-Simulator");
                c.DisplayOperationId();
            });
        }
    }

    public static void DeclareSwaggerSchema(SwaggerGenOptions swagger)
    {
        swagger.CustomSchemaIds(type => type.Name);
    }
}
