﻿using VtlSoftware.Aspects.Logging;

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
        [Log]
        public void DoSomething()
        {
        }

        #endregion
    }
}
