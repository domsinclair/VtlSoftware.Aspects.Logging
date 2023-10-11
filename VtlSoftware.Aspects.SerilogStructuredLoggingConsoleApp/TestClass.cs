using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.SerilogStructuredLoggingConsoleApp
{
    // The code fix 'Remove Aspect | InjectBasicLogging' could no longer be found. The logic that suggests the code fix may be non-deterministic.

    public  class TestClass
    {
        #region Public Methods

        [Log]
        public  void SayHello()
        {
            //logger.LogString(LogLevel.Information, $"Hello from the Test Class");
        }

        #endregion
    }
}
