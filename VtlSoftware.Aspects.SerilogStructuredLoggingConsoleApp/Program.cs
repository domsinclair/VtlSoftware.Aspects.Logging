﻿
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using VtlSoftware.Aspects.Logging;

namespace VtlSoftware.Aspects.SerilogStructuredLoggingConsoleApp
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

            // This line provides access to the application configuration.
            IConfiguration configuration = builder.Build();

            // Now the logger is initialised and we log the fact that the application has started
            // NOTE: this log message will always be written irrespective of the setting in the
            // appsettings.json file.

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Build())
                .CreateLogger();

            Log.Logger.Information("Application Startup");

            // Now the various services are setup and we instruct the logger to use Serilog.
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(
                    (context, services) =>
                    {
                        services.AddSingleton<IConfiguration>(configuration);
                        services.AddScoped<ILoggingAspect, LoggingAspect>();
                        services.AddTransient<DataFun>();
                        services.AddTransient<BasicCustomLogging>();
                        services.AddTransient<ControlledCustomLogging>();
                        services.AddTransient<SensitivedataLogging>();
                        services.AddTransient<NullResults>();
                    })
                .UseSerilog()
                .Build();

            var laspects = ActivatorUtilities.CreateInstance<LoggingAspect>(host.Services);
            var svc = ActivatorUtilities.CreateInstance<DataFun>(host.Services);
            Dictionary<int, String> contacts = svc.GetDictionary(); //this just creates the dictionary with data from Bogus

            // Note the fact that we are using plain serilog syntax in the message below and if we want 
            // structured logging we need to use string.format rather than an interpolated string.
            Log.Logger.Information("There are {0} contacts In the dictionary", contacts.Count());

            List<string> strings = svc.GetSelectedContacts(); //this will get contacts 5,15,25,35,and 45

            var bcl = ActivatorUtilities.CreateInstance<BasicCustomLogging>(host.Services);
            bcl.CalculateVat();

            var ccl = ActivatorUtilities.CreateInstance<ControlledCustomLogging>(host.Services);
            ccl.CalculateVat();

            var sdl = ActivatorUtilities.CreateInstance<SensitivedataLogging>(host.Services);
            sdl.DoSometingWithPassword("frank", "dertws12");

            var nr = ActivatorUtilities.CreateInstance<NullResults>(host.Services);
            DateTime? date = nr.Nulldays("Mon");
            DateTime? date1 = nr.Nulldays("Thu");
            DateTime? date2 = nr.Nulldays(null);
            //string? fail = nr.Failure("fail");
            //string? fail1 = nr.Failure(null);
            // Finally at the point that the application is about to exit we add an appropriate log message
            // and then shutdown the logger.

            Log.Logger.Information("Application Closing");
            Log.CloseAndFlush();
        }

        #endregion
    }
}
