using Microsoft.Extensions.Configuration;
using VtlSoftware.Aspects.Logging;

namespace VtlSoftware.Aspects.SerilogStructuredLoggingConsoleApp
{
    internal class LoggingAspect : ILoggingAspect
    {
        #region Fields
        private readonly IConfiguration configuration;

        #endregion

        #region Constructors
        public LoggingAspect(IConfiguration configuration)
        {
            this.configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            LoggingEnabled = CheckAppsettingKeyExistsAndReturnValueIfItDoesOrDefaultToTrue();
        }

        #endregion

        #region Private Methods
        private bool CheckAppsettingKeyExistsAndReturnValueIfItDoesOrDefaultToTrue()
        {
            var section = configuration.GetSection("LoggingEnabled");
            var sectionExists = section.Exists();
            if(sectionExists)
            {
                return Convert.ToBoolean(configuration.GetSection("LoggingEnabled").Value);
            } else
            {
                return true;
            }
        }

        #endregion

        #region Public Properties
        public bool LoggingEnabled { get; set; }

        #endregion
    }
}
