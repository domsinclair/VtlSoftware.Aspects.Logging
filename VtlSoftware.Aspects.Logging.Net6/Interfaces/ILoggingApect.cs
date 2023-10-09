﻿
namespace VtlSoftware.Aspects.Logging.Net6
{
    /// <summary>
    /// Interface for logging apect.
    /// </summary>
    ///
    /// <remarks></remarks>

    public interface ILoggingApect
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets a value indicating whether the logging is enabled.
        /// </summary>
        ///
        /// <value>True if logging enabled, false if not.</value>

        public bool LoggingEnabled { get; set; }

        #endregion
    }
}
