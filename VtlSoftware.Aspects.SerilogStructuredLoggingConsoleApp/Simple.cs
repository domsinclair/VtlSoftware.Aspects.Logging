using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.SerilogStructuredLoggingConsoleApp
{
    public  class Simple
    {
        #region Private Methods
        [Log]
        private  string ConvertToUpper(string value) { return value.ToUpper(); }

        #endregion
    }
}
