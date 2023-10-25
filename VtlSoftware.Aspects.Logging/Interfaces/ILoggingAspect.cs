namespace VtlSoftware.Aspects.Logging
{
    /// <summary>
    /// Interface for logging aspect.
    /// </summary>
    ///
    /// <remarks>
    /// An interface to provide a simple means to control logging.
    /// </remarks>

    public interface ILoggingAspect
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
