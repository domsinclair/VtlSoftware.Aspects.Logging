using VtlSoftware.Aspects.Logging.Net6;
namespace VtlSoftware.Aspects.Logging.Tests.net6.TimedNonVoidMethod
{
    public class TimedNonVoidMethodTest
    {
        public TimedNonVoidMethodTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.TimedNonVoidMethod.TimedNonVoidMethodTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.TimedNonVoidMethod.TimedNonVoidMethodTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
        [LogAndTime]
        public int SumIteration()
        {
            const string redacted = "<Redacted>";
            var isTracingEnabled = this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace);
            if (isTracingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Entering TimedNonVoidMethodTest.SumIteration.");
                    }
                }
            }
            global::System.Diagnostics.Stopwatch watch = global::System.Diagnostics.Stopwatch.StartNew();
            try
            {
                global::System.Int32 result;
                int val = 0;
                for (int i = 0; i < 10; i++)
                {
                    val = val + i;
                }
                result = val;
                if (isTracingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving TimedNonVoidMethodTest.SumIteration with the following result: {result}");
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
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occured in TimedNonVoidMethodTest.SumIteration. These are the details: {e}");
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
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"TimedNonVoidMethodTest.SumIteration took {millisecs} ms to complete.");
                    }
                }
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
    }
}