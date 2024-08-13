using CleanArchitecture.Domain.Interfaces.IRepositories;
using CleanArchitecture.Infrastructure.Repositories;
using CleanArchitecture.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        string? connectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

        services.AddScoped<IModel1Repository, Model1Repository>();
        services.AddScoped<IModel2Repository, Model2Repository>();
        services.AddScoped<IModel3Repository, Model3Repository>();

        return services;
    }
}
