using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace VtlSoftware.StructuredLoggingConsoleApp.Net6
{
    internal class Program
    {
        #region Private Methods

        static void BuildConfig(IConfigurationBuilder builder)
        {
            builder.SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile(
                $"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json",
                optional: true)
            .AddEnvironmentVariables();
        }

        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            BuildConfig(builder);

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Build())
                .CreateLogger();

            Log.Logger.Information("Application Startup");

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(
                    (context, services) =>
                    {
                        services.AddTransient<Calculator>();
                    })
                .UseSerilog()
                .Build();

            var svc = ActivatorUtilities.CreateInstance<Calculator>(host.Services);
            svc.Add(3.4, 7.6);

            Log.Logger.Information("Application Closing");
            Log.CloseAndFlush();
        }

        #endregion
    }
}