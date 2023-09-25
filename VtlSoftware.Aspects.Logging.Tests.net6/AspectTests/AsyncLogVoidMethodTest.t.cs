using VtlSoftware.Aspects.Logging.Net6;
namespace VtlSoftware.Aspects.Logging.Tests.net6.AsyncLogVoidMethod
{
    public class AsyncLogVoidMethodTest
    {
        public AsyncLogVoidMethodTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AsyncLogVoidMethod.AsyncLogVoidMethodTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AsyncLogVoidMethod.AsyncLogVoidMethodTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
        [Log]
        public async void DoSomething()
        {
            const string redacted = "<Redacted>";
           var isLoggingEnabled = this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace) | this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug) | this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Information);
            if (isLoggingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Entering AsyncLogVoidMethodTest.DoSomething.");
                    }
                }
            }
            try
            {
                await this.DoSomething_Source();
                object result = null;
                if (isLoggingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Leaving AsyncLogVoidMethodTest.DoSomething.");
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
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occurred in AsyncLogVoidMethodTest.DoSomething. These are the details: {e}");
                    }
                }
                throw;
            }
            //Do something here
        }
        private async global::System.Threading.Tasks.ValueTask DoSomething_Source()
        {
            //Do something here
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
    }
}