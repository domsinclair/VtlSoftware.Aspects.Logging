using System;
using VtlSoftware.Aspects.Logging;

namespace VtlSoftware.Aspects.Logging.Tests.net6.LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributes
{
    public class LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributesTest
    {
        #region Public Properties
        [NoLog]
        public DateTime MyDate { get; set; }

        [LogAndTime]
        public double MyDouble { get; set; }

        [NoLog]
        public int MyInt { get; set; }

        [LogAndTime]
        public string MyString { get; set; }

        #endregion
    }
}
