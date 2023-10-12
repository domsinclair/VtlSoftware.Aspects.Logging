using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.SerilogStructuredLoggingConsoleApp
{
    [NoLog]
    public  class Simple
    {
        #region Private Methods
        private  string ConvertToUpper(string value) { return value.ToUpper(); }

        #endregion

        #region Public Properties

        public string? MyString { get; set; }

        #endregion
    }
}
