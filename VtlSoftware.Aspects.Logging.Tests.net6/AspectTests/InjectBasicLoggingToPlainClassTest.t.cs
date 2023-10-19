using VtlSoftware.Aspects.Logging;
namespace VtlSoftware.Aspects.Logging.Tests.net6.InjectBasicLoggingToPlainClass
{
    [InjectBasicLogging]
    public class InjectBasicLoggingToPlainClassTest
    {
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public InjectBasicLoggingToPlainClassTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.InjectBasicLoggingToPlainClass.InjectBasicLoggingToPlainClassTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.InjectBasicLoggingToPlainClass.InjectBasicLoggingToPlainClassTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
    }
}