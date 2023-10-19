
using VtlSoftware.Aspects.Logging;

namespace VtlSoftware.Aspects.Logging.Tests.net6.LogPropertyWithLogAttribute
{
    public class LogPropertyWithLogAttributeTest
    {
        #region Public Properties
        [Log]
        public double MyDouble { get; set; }

        [Log]
        public string MyString { get; set; }

        #endregion
    }
}
