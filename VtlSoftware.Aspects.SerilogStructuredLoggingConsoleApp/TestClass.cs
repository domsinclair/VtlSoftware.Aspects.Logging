using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.SerilogStructuredLoggingConsoleApp
{
    public partial class TestClass
    {
        #region Public Methods
        [Log]
        public void SayHello()
        {
            //logger.LogString(LogLevel.Information, $"Hello from the Test Class");
        }

        #endregion
    }
}
