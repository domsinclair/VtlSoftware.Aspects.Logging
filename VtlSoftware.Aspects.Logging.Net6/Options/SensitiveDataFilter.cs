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

        public static bool HasSensitiveParameters(IParameter parameter, string? sensitiveParameterNames)
        {
            if(parameter.Attributes.OfAttributeType(typeof(RedactAttribute)).Any())
            {
                return true;
            }

            if(sensitiveParameterNames != null)
            {
                sensitiveParameterNames = sensitiveParameterNames.ToLowerInvariant();
                if(sensitiveParameterNames.Any(n => parameter.Name.ToLowerInvariant().Contains(n)))
                {
                    return true;
                }
            }

            return false;
        }

        #endregion
    }
}
