using Metalama.Framework.Fabrics;
using System;
using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.Logging.Tests.net6.LogAndTimeMethodsAndLogProperties
{
    public class LogAndTimeMethodsAndLogPropertiesTest
    {
        #region Constructors
        public LogAndTimeMethodsAndLogPropertiesTest()
        {
        }

        #endregion

        #region Private Methods
        private void DoSomething()
        {
        }

        #endregion

        #region Public Methods
        public void DoSomethingElse()
        {
        }

        public DateTime GetTodaysDate() { return DateTime.Now; }

        public string TrimString(string myString) { return myString.Trim(); }

        #endregion

        #region Public Properties
        public DateTime? MyDate { get; set; }

        public double myDouble { get; set; }

        public string mystring { get; set; }

        #endregion
    }

    //public class Configure : ProjectFabric
    //{
    //    #region Public Methods
    //    //public override void AmendProject(IProjectAmender amender) { amender.TimeEveryMethodAndLogEveryProperty(); }

    //    #endregion
    //}
}
