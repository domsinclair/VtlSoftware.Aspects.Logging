﻿using VtlSoftware.Aspects.Logging;

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
        [Log]
        public int AddSomething() { return 1; }

        #endregion
    }
}
