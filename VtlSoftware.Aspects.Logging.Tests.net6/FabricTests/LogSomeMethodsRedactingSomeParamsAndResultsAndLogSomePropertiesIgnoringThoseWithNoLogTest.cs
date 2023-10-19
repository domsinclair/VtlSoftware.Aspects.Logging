using Metalama.Framework.Fabrics;
using System;
using VtlSoftware.Aspects.Logging;

namespace VtlSoftware.Aspects.Logging.Tests.net6.LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLog
{
    public class LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest
    {
        #region Private Methods

        private Boolean TestPasswordValidity([Redact] String password)
        {
            //do stuff
            return true;
        }

        #endregion

        #region Public Methods
        public DateTime GetTodaysDate() { return DateTime.Now; }

        [return: Redact]
        public double SecretAddition(double a, double b) { return a + b; }

        [NoLog]
        public string TrimString(string myString) { return myString.Trim(); }

        #endregion

        #region Public Properties
        public DateTime? MyDate { get; set; }

        public double myDouble { get; set; }

        [NoLog]
        public string mystring { get; set; }

        #endregion
    }

    public class Configure : ProjectFabric
    {
        #region Public Methods
        public override void AmendProject(IProjectAmender amender) { amender.LogEverything(); }

        #endregion
    }
}

