using VtlSoftware.Aspects.Logging.Net6;
namespace VtlSoftware.Aspects.Logging.Tests.net6.LogNonVoidMethod
{
    public class LogNonVoidMethodTest
    {
        public LogNonVoidMethodTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogNonVoidMethod.LogNonVoidMethodTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogNonVoidMethod.LogNonVoidMethodTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
        [Log]
        public int AddSomething()
        {
            const string redacted = "<Redacted>";
            var isTracingEnabled = this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace);
            if (isTracingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Entering LogNonVoidMethodTest.AddSomething.");
                    }
                }
            }
            try
            {
                global::System.Int32 result;
                result = 1;
                if (isTracingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving LogNonVoidMethodTest.AddSomething with the following result: {result}");
                        }
                    }
                }
                return (global::System.Int32)result;
            }
            catch (global::System.Exception e) when (this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                using (var guard_2 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard_2.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occured in LogNonVoidMethodTest.AddSomething. These are the details: {e}");
                    }
                }
                throw;
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
    }
}