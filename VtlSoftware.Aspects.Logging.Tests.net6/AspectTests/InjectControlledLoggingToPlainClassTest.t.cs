using VtlSoftware.Aspects.Logging;
namespace VtlSoftware.Aspects.Logging.Tests.net6.InjectControlledLoggingToPlainClass
{
    [InjectControlledLogging]
    public class InjectControlledLoggingToPlainClassTest
    {
        private global::Microsoft.Extensions.Logging.ILogger logger;
        private global::VtlSoftware.Aspects.Logging.ILoggingApect loggingApect;
        public InjectControlledLoggingToPlainClassTest(global::VtlSoftware.Aspects.Logging.ILoggingApect? loggingApect = default(global::VtlSoftware.Aspects.Logging.ILoggingApect?), global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.InjectControlledLoggingToPlainClass.InjectControlledLoggingToPlainClassTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.InjectControlledLoggingToPlainClass.InjectControlledLoggingToPlainClassTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            this.loggingApect = loggingApect ?? throw new System.ArgumentNullException(nameof(loggingApect));
        }
    }
}