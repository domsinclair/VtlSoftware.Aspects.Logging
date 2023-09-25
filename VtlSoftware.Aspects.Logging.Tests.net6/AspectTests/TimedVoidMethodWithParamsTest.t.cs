using System;
using VtlSoftware.Aspects.Logging.Net6;
namespace VtlSoftware.Aspects.Logging.Tests.net6.TimedVoidMethodWithParams
{
    public class TimedVoidMethodWithParamsTest
    {
        public TimedVoidMethodWithParamsTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.TimedVoidMethodWithParams.TimedVoidMethodWithParamsTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.TimedVoidMethodWithParams.TimedVoidMethodWithParamsTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
        [LogAndTime]
        public void IterateOverRange(int range)
        {
            const string redacted = "<Redacted>";
           var isLoggingEnabled = this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace) | this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug) | this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Information);
            if (isLoggingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object> parameters = new();
                        parameters.Add("Type = int: Parameter Name = range", range);
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Entering TimedVoidMethodWithParamsTest.IterateOverRange with these parameters: {parameters}");
                    }
                }
            }
            global::System.Diagnostics.Stopwatch watch = global::System.Diagnostics.Stopwatch.StartNew();
            try
            {
                for (int i = 0; i < range; i++)
                {
                    Console.WriteLine(i);
                }
                object result = null;
                if (isLoggingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Leaving TimedVoidMethodWithParamsTest.IterateOverRange.");
                        }
                    }
                }
                return;
            }
            catch (global::System.Exception e) when (this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                using (var guard_2 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard_2.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occurred in TimedVoidMethodWithParamsTest.IterateOverRange. These are the details: {e}");
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
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"TimedVoidMethodWithParamsTest.IterateOverRange took {millisecs} ms to complete.");
                    }
                }
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
    }
}