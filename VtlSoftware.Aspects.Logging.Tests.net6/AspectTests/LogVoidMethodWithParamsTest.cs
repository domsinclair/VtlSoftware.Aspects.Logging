﻿using VtlSoftware.Aspects.Logging;

namespace VtlSoftware.Aspects.Logging.Tests.net6.LogVoidMethodWithParams
{
    public class LogVoidMethodWithParamsTest
    {
        #region Constructors
        public LogVoidMethodWithParamsTest()
        {
        }

        #endregion

        #region Public Methods
        [Log]
        public void DoSomething(string stringToChange)
        {
        }

        #endregion
    }
}
