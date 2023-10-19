using VtlSoftware.Aspects.Logging;
namespace VtlSoftware.Aspects.Logging.Tests.net6.RedactedParametersAndResults
{
    public class RedactedParametersAndResultsTest
    {
        public RedactedParametersAndResultsTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.RedactedParametersAndResults.RedactedParametersAndResultsTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.RedactedParametersAndResults.RedactedParametersAndResultsTest>), global::VtlSoftware.Aspects.Logging.ILoggingApect? loggingApect = default(global::VtlSoftware.Aspects.Logging.ILoggingApect?))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            this.loggingApect = loggingApect ?? throw new System.ArgumentNullException(nameof(loggingApect));
        }
        [Log]
        [return: Redact]
        public string ValidateCardNumber(string userName, [Redact] string cardNumber)
        {
            var isLoggingEnabled = this.loggingApect.LoggingEnabled;
            if (isLoggingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object> parameters = new();
                        parameters.Add("Type = string: Parameter Name = userName", userName);
                        parameters.Add("Type = string: Parameter Name =cardNumber", "Redacted");
                        global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Entering RedactedParametersAndResultsTest.ValidateCardNumber with these parameters: {parameters}");
                    }
                }
            }
            try
            {
                global::System.String result;
                cardNumber.Trim();
                result = cardNumber;
                if (isLoggingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Aspects.Common.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Leaving RedactedParametersAndResultsTest.ValidateCardNumber : The result has been redacted to protect sensitive data.");
                        }
                    }
                }
                return (global::System.String)result;
            }
            catch (global::System.Exception e) when (this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                using (var guard_2 = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                {
                    if (guard_2.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occurred in RedactedParametersAndResultsTest.ValidateCardNumber. These are the details: {e}");
                    }
                }
                throw;
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        private global::VtlSoftware.Aspects.Logging.ILoggingApect loggingApect;
    }
}