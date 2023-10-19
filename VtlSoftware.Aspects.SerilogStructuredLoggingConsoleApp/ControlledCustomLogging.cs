using Microsoft.Extensions.Logging;
using VtlSoftware.Aspects.Common;
using VtlSoftware.Aspects.Logging;

namespace VtlSoftware.Aspects.SerilogStructuredLoggingConsoleApp
{
    // In the class below The Microsoft.Extensions.Logging. ILogger is 
    // being injected into the class and we can reference it with the variable 'logger'.
    // 
    // It also injects the VtlSoftware.Aspects.Logging ILoggingAspect and it is that that 
    // allows us to exercise some external control
    //
    // Creating a custom log message then becomes as simple as is illustrated in
    // the code below.  If you invoke Show Metalama diffs you can see the code injection.
    // 
    // Try switching the LoggerEnabled value in the appsettings.json file between true and false 
    // and see it's effect on this class'scustom log message.

    [InjectControlledLogging]
    internal partial class ControlledCustomLogging

    {
        #region Private Methods

        private double GetCustomerRate() { return 17.5; }

        #endregion

        #region Public Methods
        public double CalculateVat()
        {
            var rate = GetCustomerRate();
            var isLoggingEnabled = this.loggingApect.LoggingEnabled;
            if(isLoggingEnabled)
            {
                using(var guard = LogRecursionGuard.Begin())
                {
                    if(guard.CanLog)
                    {
                        logger.Log(
                            LogLevel.Information,
                            $"The returned vat rate from the Controlled Custom Logging Class was {rate}");
                    }
                }
            }
            return (100 * rate / 100);
        }

        #endregion
    }
}
