using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.SerilogStructuredLoggingConsoleApp
{
    internal class SensitivedataLogging
    {
        #region Public Methods
        [Log]
        public string DoSometingWithPassword(string value, string password) { return "Fred"; }

        #endregion
    }
}
