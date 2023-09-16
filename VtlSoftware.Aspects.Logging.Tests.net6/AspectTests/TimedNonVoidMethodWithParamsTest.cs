using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.Logging.Tests.net6.TimedNonVoidMethodWithParams
{
    public  class TimedNonVoidMethodWithParamsTest
    {
        #region Constructors
        public TimedNonVoidMethodWithParamsTest()
        {
        }

        #endregion

        #region Public Methods
        [LogAndTime]
        public int IterateOverRange(int range)
        {
            int val = 0;
            for(int i = 0; i < range; i++)
            {
                val = val + i;
            }

            return val;
        }

        #endregion
    }
}
