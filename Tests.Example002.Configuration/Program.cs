using Microsoft.Extensions.Configuration;

namespace Tests.Example002.Configuration;

internal class Program
{
    private static IConfiguration _cfg = null!;
    private static Options? _options;
    
    private static void Main(string[] args)
    {
        _cfg = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json",
                           optional: false, reloadOnChange: true)
              .AddJsonFile($"appsettings.Development.json",
                           optional: true, reloadOnChange: true)
              .AddUserSecrets<Program>(true)
              .AddEnvironmentVariables()
              .AddCommandLine(args)
              .Build();

        _options =  _cfg.GetSection(nameof(Options))
                        .Get<Options>();

        Console.WriteLine(_options);
    }
}