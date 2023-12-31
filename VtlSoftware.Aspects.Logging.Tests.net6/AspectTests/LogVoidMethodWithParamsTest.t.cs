using VtlSoftware.Aspects.Logging;
namespace VtlSoftware.Aspects.Logging.Tests.net6.LogVoidMethodWithParams
{
    public class LogVoidMethodWithParamsTest
    {
        public LogVoidMethodWithParamsTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogVoidMethodWithParams.LogVoidMethodWithParamsTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogVoidMethodWithParams.LogVoidMethodWithParamsTest>), global::VtlSoftware.Aspects.Logging.ILoggingAspect? loggingAspect = default(global::VtlSoftware.Aspects.Logging.ILoggingAspect?))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            this.loggingAspect = loggingAspect ?? throw new System.ArgumentNullException(nameof(loggingAspect));
        }
        [Log]
        public void DoSomething(string stringToChange)
        {
            var isLoggingEnabled = this.loggingAspect.LoggingEnabled;
            if (isLoggingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object> parameters = new();
                        parameters.Add("Type = string: Parameter Name = stringToChange", stringToChange);
                        global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Entering LogVoidMethodWithParamsTest.DoSomething with these parameters: {parameters}");
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
                            global::VtlSoftware.Aspects.Common.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Leaving LogVoidMethodWithParamsTest.DoSomething.");
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
                        global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occurred in LogVoidMethodWithParamsTest.DoSomething. These are the details: {e}");
                    }
                }
                throw;
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        private global::VtlSoftware.Aspects.Logging.ILoggingAspect loggingAspect;
    }
}