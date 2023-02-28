using App004.GrpsService.Services;

namespace App004.GrpsService;

internal static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddGrpc();

        var app = builder.Build();
        app.MapGrpcService<GreeterService>();
        app.MapGet("/", () => "Hello World!");
        app.Run();
    }
}