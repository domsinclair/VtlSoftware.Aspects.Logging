using System;
using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.Logging.Tests.net6.TimedVoidMethod
{
    public class TimedVoidMethodTest
    {
        #region Constructors

        public TimedVoidMethodTest()
        {
        }

        #endregion

        #region Public Methods
        [TimedLogMethod]
        public void Iterate()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        #endregion
    }
}
