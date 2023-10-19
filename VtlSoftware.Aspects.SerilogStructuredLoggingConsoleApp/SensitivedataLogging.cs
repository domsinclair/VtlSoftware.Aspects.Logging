using VtlSoftware.Aspects.Logging;

namespace VtlSoftware.Aspects.SerilogStructuredLoggingConsoleApp
{
    internal partial class SensitivedataLogging
    {
        #region Public Methods

        [Log]
        public string DoSometingWithPassword(string value, string password) { return "Fred"; }

        #endregion
    }
}
