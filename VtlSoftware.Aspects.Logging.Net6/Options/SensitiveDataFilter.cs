using Metalama.Framework.Aspects;
using Metalama.Framework.Code;
using System.Diagnostics;

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
            Debugger.Break();
            if(!string.IsNullOrEmpty(sensitiveParameterNames))
            {
                sensitiveParameterNames = sensitiveParameterNames.ToLowerInvariant();
                List<string> paramNames = sensitiveParameterNames.Split(',').ToList();
                if(paramNames.Any(n => parameter.Name.ToLowerInvariant().Contains(n)))
                {
                    return true;
                }
            } else
            {
                List<string> paramNames = fallback.Split(',').ToList();
                if(paramNames.Any(n => parameter.Name.ToLowerInvariant().Contains(n)))
                {
                    return true;
                }
            }

            return false;
        }

        #endregion
    }
}
