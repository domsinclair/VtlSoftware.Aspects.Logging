
using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.SerilogStructuredLoggingConsoleApp
{
    /// <summary>
    /// A log and time example class.
    /// </summary>
    ///
    /// <remarks>A selection of examples that demonstrate using the [LogAndTime] aspect.</remarks>

    public partial class LogAndTimeExampleClass
    {
        #region Public Methods
        [LogAndTime]
        [return: Redact]
        public double CalculateWeeklyWage([Redact] string employee, double hourlyRate, double hoursWorked)
        {
            // In addition to logging Entry and Exit
            // this will also log the parameters and
            // the return, but the employee name and
            // the result will be redacted as the information
            // might be sensitive.
            // The Time taken to complete the method will be recorded.

            var result = hoursWorked * hourlyRate;
            if(hoursWorked > 40)
            {
                // Do some work to determine employees overtime rate
                // set result to result + whatever the overtime calculation yields.
            }
            return result;
        }

        [LogAndTime]
        public string ConvertToUpperAccordingToCulture(string value)
        {
            // In addition to logging Entry and Exit
            // this will also log the parameters and
            // the return.
            // The Time taken to complete the method will be recorded.
            return value.ToUpperInvariant();
        }

        [LogAndTime]
        public void DoNothing()
        {
            // This will log the entry and Exit only.
            // The Time taken to complete the method will be recorded.
        }

        #endregion

        #region Public Properties
        // The property below will have both the getter
        // and setter (old and new values) logged.
        // It WILL NOT record the time taken.
        [LogAndTime]
        public string AStringProperty { get; set; }

        #endregion
    }
}
