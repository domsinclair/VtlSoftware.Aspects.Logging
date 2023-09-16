using VtlSoftware.Aspects.Logging.Net6;
namespace VtlSoftware.Aspects.Logging.Tests.net6.RedactedParametersAndResults
{
    public class RedactedParametersAndResultsTest
    {
        public RedactedParametersAndResultsTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.RedactedParametersAndResults.RedactedParametersAndResultsTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.RedactedParametersAndResults.RedactedParametersAndResultsTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
        [Log]
        [return: Redact]
        public string ValidateCardNumber(string userName, [Redact] string cardNumber)
        {
            const string redacted = "<Redacted>";
            var isTracingEnabled = this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace);
            if (isTracingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object> parameters = new();
                        parameters.Add("Type = string: Parameter Name = userName", userName);
                        parameters.Add("Type = string: Parameter Name =cardNumber", redacted);
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Entering RedactedParametersAndResultsTest.ValidateCardNumber with these parameters: {parameters}");
                    }
                }
            }
            try
            {
                global::System.String result;
                cardNumber.Trim();
                result = cardNumber;
                if (isTracingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving RedactedParametersAndResultsTest.ValidateCardNumber with the following result which has been {redacted}");
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
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occured in RedactedParametersAndResultsTest.ValidateCardNumber. These are the details: {e}");
                    }
                }
                throw;
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
    }
}