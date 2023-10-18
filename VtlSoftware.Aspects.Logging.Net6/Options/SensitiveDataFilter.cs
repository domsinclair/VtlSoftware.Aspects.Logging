using Metalama.Framework.Aspects;
using Metalama.Framework.Code;

namespace VtlSoftware.Aspects.Logging.Net6
{
    /// <summary>
    /// A sensitive data filter.
    /// </summary>
    ///
    /// <remarks></remarks>

    [RunTimeOrCompileTime]
    internal static class SensitiveDataFilter
    {
        #region Constants

        const string fallback = "password,pwd,secret";

        #endregion

        #region Public Methods
        /// <summary>
        /// Query if 'parameter' has sensitive parameters.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <param name="parameter">The parameter.</param>
        /// <param name="sensitiveParameterNames">List of names of the sensitive parameters.</param>
        ///
        /// <returns>True if sensitive parameters, false if not.</returns>

        public static bool HasSensitiveParameters(IParameter parameter, string sensitiveParameterNames)
        {
            if(parameter.Attributes.OfAttributeType(typeof(RedactAttribute)).Any())
            {
                return true;
            }

            if(!string.IsNullOrEmpty(sensitiveParameterNames))
            {
                return sensitiveParameterNames.Split(',').Contains(
                    parameter.Name,
                    StringComparer.InvariantCultureIgnoreCase);
            } else
            {
                return fallback.Split(',').Contains(parameter.Name, StringComparer.InvariantCultureIgnoreCase);
            }
        }

        #endregion
    }
}
