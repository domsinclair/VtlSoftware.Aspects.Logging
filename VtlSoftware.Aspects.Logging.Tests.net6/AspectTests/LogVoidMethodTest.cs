﻿using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.Logging.Tests.net6.LogVoidMethod
{
    public class LogVoidMethodTest
    {
        #region Constructors
        public LogVoidMethodTest()
        {
        }

        #endregion

        #region Public Methods
        [LogMethod]
        public void DoSomething()
        {
        }

        #endregion
    }
}
