using VtlSoftware.Aspects.Logging;

namespace VtlSoftware.Aspects.Logging.Tests.net6.TimedNonVoidMethod
{
    public class TimedNonVoidMethodTest
    {
        #region Constructors
        public TimedNonVoidMethodTest()
        {
        }

        #endregion

        #region Public Methods
        [LogAndTime]
        public int SumIteration()
        {
            int val = 0;
            for(int i = 0; i < 10; i++)
            {
                val = val + i;
            }
            return val;
        }

        #endregion
    }
}
