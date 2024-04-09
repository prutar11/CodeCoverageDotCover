using CodeCoverage;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddTransient<IMathHelperService, MathHelperService>();
    })
    .UseConsoleLifetime();

var host = builder.Build();
host.Run();