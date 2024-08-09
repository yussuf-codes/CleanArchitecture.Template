using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using CleanArchitecture.Presentation.Extensions;
using CleanArchitecture.Application.Extensions;
using CleanArchitecture.Infrastructure.Extensions;

namespace CleanArchitecture.Presentation;

public static class Program
{
    public static async Task Main()
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder();

        builder.Services.AddPresentationServices()
                        .AddApplicationServices()
                        .AddInfrastructureServices(builder.Configuration);

        string AllowAllOrigins = "AllowAllOrigins";

        builder.Services.AddCors(options =>
        {
            options.AddPolicy(name: AllowAllOrigins, policyBuilder =>
            {
                policyBuilder.AllowAnyOrigin();
                policyBuilder.AllowAnyHeader();
                policyBuilder.AllowAnyMethod();
            });
        });

        WebApplication app = builder.Build();

        app.UseCors(AllowAllOrigins);

        await app.RunAsync();
    }
}
