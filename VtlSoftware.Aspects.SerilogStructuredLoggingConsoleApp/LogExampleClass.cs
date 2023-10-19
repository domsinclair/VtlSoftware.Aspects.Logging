using VtlSoftware.Aspects.Logging;

namespace VtlSoftware.Aspects.SerilogStructuredLoggingConsoleApp
{
    /// <summary>
    /// A log example class.
    /// </summary>
    ///
    /// <remarks>A selection of examples that demonstrate using the [Log] aspect.</remarks>

    public partial class LogExampleClass
    {
        #region Public Methods

        [Log]
        [return: Redact]
        public double CalculateWeeklyWage([Redact]string employee, double hourlyRate, double hoursWorked)
        {
            // In addition to logging Entry and Exit
            // this will also log the parameters and
            // the return, but the employee name and
            // the result will be redacted as the information
            // might be sensitive

            var result = hoursWorked * hourlyRate;
            if(hoursWorked > 40)
            {
                // Do some work to determine employees overtime rate
                // set result to result + whatever the overtime calculation yields.
            }
            return result;
        }

        [Log]
        public string ConvertToUpperAccordingToCulture(string value)
        {
            // In addition to logging Entry and Exit
            // this will also log the parameters and
            // the return.
            return value.ToUpperInvariant();
        }

        [Log]
        public void DoNothing()
        {
            // This will log the entry and Exit only
        }

        #endregion

        #region Public Properties
        // The property below will have both the getter
        // and setter (old and new values) logged.
        [Log]
        public string? AStrinProperty { get; set; }

        #endregion
    }
}
