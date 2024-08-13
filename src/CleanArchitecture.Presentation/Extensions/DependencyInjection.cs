using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Presentation.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentationServices(this IServiceCollection services)
    {
        services.AddControllers();

        services.AddCors(options =>
        {
            options.AddPolicy(name: "AllowAllOrigins", policyBuilder =>
            {
                policyBuilder.AllowAnyOrigin();
                policyBuilder.AllowAnyHeader();
                policyBuilder.AllowAnyMethod();
            });
        });

        return services;
    }
}
