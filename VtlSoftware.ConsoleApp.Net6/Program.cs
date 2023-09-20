using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace VtlSoftware.ConsoleApp.Net6
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
                        services.AddTransient<General>();
                    })
                .UseSerilog()
                .Build();

            //try
            //{
            General general = new General();
            general.MyString = "Hi There";
            //} catch(Exception ex)
            //{
            //    Log.Logger.Warning($"Ther has been an error.  This is the message: {ex.StackTrace.ToString()}");
            //}

            Log.CloseAndFlush();
        }

        #endregion

        #region Public Methods
        public int Add(int x, int y) { return x + y; }

        #endregion
    }
}