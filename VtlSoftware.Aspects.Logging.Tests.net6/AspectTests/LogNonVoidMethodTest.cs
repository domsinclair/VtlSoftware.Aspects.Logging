using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.Logging.Tests.net6.LogNonVoidMethod
{
    public class LogNonVoidMethodTest
    {
        #region Constructors
        public LogNonVoidMethodTest()
        {
        }

        #endregion

        #region Public Methods
        [LogMethod]
        public int AddSomething() { return 1; }

        #endregion
    }
}
