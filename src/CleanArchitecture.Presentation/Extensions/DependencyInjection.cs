using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Presentation.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentationServices(this IServiceCollection services)
    {
        services.AddControllers();

        return services;
    }
}
