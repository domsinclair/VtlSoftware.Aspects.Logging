using Metalama.Framework.Fabrics;
using System;
using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.Logging.Tests.net6.LogAllProperties
{
    public class LogAllPropertiesTest
    {
        #region Constructors

        public LogAllPropertiesTest()
        {
        }

        #endregion

        #region Public Properties
        public DateTime MyDateTime { get; set; }

        public decimal MyDecimal { get; set; }

        public double MyDouble { get; set; }

        public int MyInteger { get; set; }

        public string myString { get; set; }

        #endregion
    }

    public class Configure : ProjectFabric
    {
        #region Public Methods
        public override void AmendProject(IProjectAmender amender) { amender.LogAllProperties(); }

        #endregion
    }
}
