using Microsoft.Extensions.Logging;
using VtlSoftware.Aspects.Common;
using VtlSoftware.Aspects.Logging;

namespace VtlSoftware.Aspects.SerilogStructuredLoggingConsoleApp
{
    // In the class below The Microsoft.Extensions.Logging. ILogger is 
    // being injected into the class and we can reference it with the variable 'logger'.
    //
    // Creating a custom log message then becomes as simple as is illustrated in
    // the code below.  If you invoke Show Metalama diffs you can see the code injection.

    [InjectBasicLogging]
    internal partial class BasicCustomLogging
    {
        #region Private Methods
        private double GetCustomerRate() { return 17.5; }

        #endregion

        #region Public Methods
        public double CalculateVat()
        {
            var rate = GetCustomerRate();
            logger.Log(LogLevel.Information, $"The returned vat rate from the Basic Logging Class was {rate}");
            return (100 * rate / 100);
        }

        #endregion
    }
}
