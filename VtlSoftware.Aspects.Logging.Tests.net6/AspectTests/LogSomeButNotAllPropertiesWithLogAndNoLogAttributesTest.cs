using System;
using VtlSoftware.Aspects.Logging;

namespace VtlSoftware.Aspects.Logging.Tests.net6.LogSomeButNotAllPropertiesWithLogAndNoLogAttributes
{
    public class LogSomeButNotAllPropertiesWithLogAndNoLogAttributesTest
    {
        #region Public Properties
        [NoLog]
        public DateTime MyDate { get; set; }

        [Log]
        public double MyDouble { get; set; }

        [NoLog]
        public int MyInt { get; set; }

        [Log]
        public string MyString { get; set; }

        #endregion
    }
}
