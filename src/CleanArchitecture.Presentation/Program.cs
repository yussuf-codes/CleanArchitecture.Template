using Microsoft.AspNetCore.Builder;
using CleanArchitecture.Presentation.Extensions;
using CleanArchitecture.Application.Extensions;
using CleanArchitecture.Infrastructure.Extensions;

namespace CleanArchitecture.Presentation;

public static class Program
{
    public static void Main()
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder();

        builder.Services.AddPresentationServices()
                        .AddApplicationServices()
                        .AddInfrastructureServices(builder.Configuration);

        WebApplication app = builder.Build();

        app.Run();
    }
}
