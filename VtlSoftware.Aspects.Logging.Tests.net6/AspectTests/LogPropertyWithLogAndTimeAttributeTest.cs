
using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.Logging.Tests.net6.LogPropertyWithLogAndTimeAttribute
{
    public class LogPropertyWithLogAndTimeAttributeTest
    {
        #region Public Properties

        [LogAndTime]
        public double MyDouble { get; set; }

        [LogAndTime]
        public string MyString { get; set; }

        #endregion
    }
}
