using System;
using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.Logging.Tests.net6.TimedVoidMethodWithParams
{
    public class TimedVoidMethodWithParamsTest
    {
        #region Constructors

        public TimedVoidMethodWithParamsTest()
        {
        }

        #endregion

        #region Public Methods
        [TimedLogMethod]
        public void IterateOverRange(int range)
        {
            for(int i = 0; i < range; i++)
            {
                Console.WriteLine(i);
            }
        }

        #endregion
    }
}
