using Metalama.Framework.Fabrics;
using System;
using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.Logging.Tests.net6.LogAndTimeSomeMethodsAndLogSomePropertiesIgnoringThoseWithNoLog
{
    public class LogAndTimeSomeMethodsAndLogSomePropertiesIgnoringThoseWithNoLogTest
    {
        #region Constructors

        public LogAndTimeSomeMethodsAndLogSomePropertiesIgnoringThoseWithNoLogTest()
        {
        }

        #endregion

        #region Public Methods
        public DateTime GetTodaysDate() { return DateTime.Now; }

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
        public override void AmendProject(IProjectAmender amender) { amender.TimeEveryMethodAndLogEveryProperty(); }

        #endregion
    }
}

