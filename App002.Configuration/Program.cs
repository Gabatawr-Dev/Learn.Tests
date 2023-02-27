using Microsoft.Extensions.Configuration;

namespace App002.Configuration;

internal class Program
{
    private static IConfiguration _cfg = null!;
    private static Options _options = null!;
    
    private static void Main(string[] args)
    {
        _cfg = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json",false, true)
              .AddJsonFile($"appsettings.Development.json", true, true)
              .AddUserSecrets<Program>(true, true)
              .AddEnvironmentVariables()
              .AddCommandLine(args)
              .Build();

        _options = _cfg.GetSection(nameof(Options))
                       .Get<Options>() ?? throw new NullReferenceException(nameof(_options));
        Console.WriteLine(_options);

        var value = _cfg.GetValue<string>("Tests:Example");
        Console.WriteLine($"UserSecrets: Example - {value}");
    }
}