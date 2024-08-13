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

        builder.Services.AddInfrastructureServices(builder.Configuration)
                        .AddApplicationServices()
                        .AddPresentationServices();

        WebApplication app = builder.Build();

        app.UseCors("AllowAllOrigins");

        app.MapControllers();

        await app.RunAsync();
    }
}
