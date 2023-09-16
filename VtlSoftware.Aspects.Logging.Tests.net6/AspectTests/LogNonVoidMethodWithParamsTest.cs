using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.Logging.Tests.net6.LogNonVoidMethodWithParams
{
    public class LogNonVoidMethodWithParamsTest
    {
        #region Constructors

        public LogNonVoidMethodWithParamsTest()
        {
        }

        #endregion

        #region Public Methods
        [Log]
        public int AddSomething(int a, int b) { return a + b; }

        #endregion
    }
}
