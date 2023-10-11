// Warning VTL101 on `LogClass`: `This class has already had aspects applied to it (possibly via a fabric) that have introduced the ILogger interface via Dependency Ijection. You will be able to add your own custom log messages. Remove the [InjectBasicLogging] Aspect`
// Warning VTL101 on `LogAnTimeClassClass`: `This class has already had aspects applied to it (possibly via a fabric) that have introduced the ILogger interface via Dependency Ijection. You will be able to add your own custom log messages. Remove the [InjectBasicLogging] Aspect`
using Metalama.Framework.Fabrics;
using VtlSoftware.Aspects.Logging.Net6;
namespace VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectInThem
{
    public class AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectInThemTest
    {
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectInThemTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectInThem.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectInThemTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectInThem.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectInThemTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
    }
    public class Test1
    {
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public Test1(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectInThem.Test1> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectInThem.Test1>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
    }
    internal class Test2
    {
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public Test2(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectInThem.Test2> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectInThem.Test2>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
    }
    public class LogClass
    {
        [Log]
        private string GetMyString()
        {
            var isLoggingEnabled = this.loggingApect.LoggingEnabled;
            if (isLoggingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Entering LogClass.GetMyString.");
                    }
                }
            }
            try
            {
                global::System.String result;
                result = "Hi";
                if (isLoggingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving LogClass.GetMyString with the following result: {result}");
                        }
                    }
                }
                return (global::System.String)result;
            }
            catch (global::System.Exception e) when (this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                using (var guard_2 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard_2.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occurred in LogClass.GetMyString. These are the details: {e}");
                    }
                }
                throw;
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        private global::VtlSoftware.Aspects.Logging.Net6.ILoggingApect loggingApect;
        public LogClass(global::VtlSoftware.Aspects.Logging.Net6.ILoggingApect? loggingApect = default(global::VtlSoftware.Aspects.Logging.Net6.ILoggingApect?), global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectInThem.LogClass> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectInThem.LogClass>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            this.loggingApect = loggingApect ?? throw new System.ArgumentNullException(nameof(loggingApect));
        }
    }
    public class LogAnTimeClassClass
    {
        [LogAndTime]
        private string GetMyString()
        {
            var isLoggingEnabled = this.loggingApect.LoggingEnabled;
            if (isLoggingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Entering LogAnTimeClassClass.GetMyString.");
                    }
                }
            }
            global::System.Diagnostics.Stopwatch watch = global::System.Diagnostics.Stopwatch.StartNew();
            try
            {
                global::System.String result;
                result = "Hi";
                if (isLoggingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving LogAnTimeClassClass.GetMyString with the following result: {result}");
                        }
                    }
                }
                return (global::System.String)result;
            }
            catch (global::System.Exception e) when (this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                using (var guard_2 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard_2.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occurred in LogAnTimeClassClass.GetMyString. These are the details: {e}");
                    }
                }
                throw;
            }
            finally
            {
                watch.Stop();
                long millisecs = watch.ElapsedMilliseconds;
                using (var guard_3 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard_3.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"LogAnTimeClassClass.GetMyString took {millisecs} ms to complete.");
                    }
                }
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        private global::VtlSoftware.Aspects.Logging.Net6.ILoggingApect loggingApect;
        public LogAnTimeClassClass(global::VtlSoftware.Aspects.Logging.Net6.ILoggingApect? loggingApect = default(global::VtlSoftware.Aspects.Logging.Net6.ILoggingApect?), global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectInThem.LogAnTimeClassClass> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectInThem.LogAnTimeClassClass>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            this.loggingApect = loggingApect ?? throw new System.ArgumentNullException(nameof(loggingApect));
        }
    }
#pragma warning disable CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
    public class Configure : ProjectFabric
    {
        public override void AmendProject(IProjectAmender amender) => throw new System.NotSupportedException("Compile-time-only code cannot be called at run-time.");
    }
#pragma warning restore CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
}