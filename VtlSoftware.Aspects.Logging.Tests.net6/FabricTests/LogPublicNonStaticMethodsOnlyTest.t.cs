using Metalama.Framework.Fabrics;
using VtlSoftware.Aspects.Logging;
namespace VtlSoftware.Aspects.Logging.Tests.net6.LogPublicNonStaticMethodsOnly
{
    public class LogPublicNonStaticMethodsOnlyTest
    {
        private void DoSomethingElse()
        {
        }
        public int Add(int a, int b)
        {
            var isLoggingEnabled = this.loggingAspect.LoggingEnabled;
            if (isLoggingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object> parameters = new();
                        parameters.Add("Type = int: Parameter Name = a", a);
                        parameters.Add("Type = int: Parameter Name = b", b);
                        global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Entering LogPublicNonStaticMethodsOnlyTest.Add with these parameters: {parameters}");
                    }
                }
            }
            try
            {
                global::System.Int32 result;
                result = a + b;
                if (isLoggingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving LogPublicNonStaticMethodsOnlyTest.Add with the following result: {result}");
                        }
                    }
                }
                return (global::System.Int32)result;
            }
            catch (global::System.Exception e) when (this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                using (var guard_2 = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                {
                    if (guard_2.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occurred in LogPublicNonStaticMethodsOnlyTest.Add. These are the details: {e}");
                    }
                }
                throw;
            }
        }
        public void DoSomething()
        {
            var isLoggingEnabled = this.loggingAspect.LoggingEnabled;
            if (isLoggingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Entering LogPublicNonStaticMethodsOnlyTest.DoSomething.");
                    }
                }
            }
            try
            {
                object result = null;
                if (isLoggingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Aspects.Common.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Leaving LogPublicNonStaticMethodsOnlyTest.DoSomething.");
                        }
                    }
                }
                return;
            }
            catch (global::System.Exception e) when (this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                using (var guard_2 = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                {
                    if (guard_2.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occurred in LogPublicNonStaticMethodsOnlyTest.DoSomething. These are the details: {e}");
                    }
                }
                throw;
            }
        }
        [NoLog]
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        private global::VtlSoftware.Aspects.Logging.ILoggingAspect loggingAspect;
        public LogPublicNonStaticMethodsOnlyTest(global::VtlSoftware.Aspects.Logging.ILoggingAspect? loggingAspect = default(global::VtlSoftware.Aspects.Logging.ILoggingAspect?), global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogPublicNonStaticMethodsOnly.LogPublicNonStaticMethodsOnlyTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogPublicNonStaticMethodsOnly.LogPublicNonStaticMethodsOnlyTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            this.loggingAspect = loggingAspect ?? throw new System.ArgumentNullException(nameof(loggingAspect));
        }
    }
    public static class DoStuff
    {
        public static void DoMoreStuff()
        {
        }
    }
#pragma warning disable CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
    public class Configure : ProjectFabric
    {
        public override void AmendProject(IProjectAmender amender) => throw new System.NotSupportedException("Compile-time-only code cannot be called at run-time.");
    }
#pragma warning restore CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
}