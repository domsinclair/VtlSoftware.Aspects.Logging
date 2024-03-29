﻿using Metalama.Framework.Fabrics;

namespace VtlSoftware.Aspects.Logging.Tests.net6.ThrowAnErrorIfClassMarkedAsNoLogButLogAndTimeAdded
{
    [NoLog]
    internal class ThrowAnErrorIfClassMarkedAsNoLogButLogAndTimeAddedTest
    {
        #region Private Methods

        private void DoSomethingElse()
        {
        }

        #endregion

        #region Public Methods
        public int Add(int a, int b) { return a + b; }

        [LogAndTime]
        public void DoSomething()
        {
        }

        public int Subtract(int a, int b) { return a - b; }

        #endregion
    }

    public static class Static1
    {
        #region Public Methods
        public static void DoMoreStuff()
        {
        }

        #endregion
    }

    public class SecondFabric : ProjectFabric
    {
        #region Public Methods

        public override void AmendProject(IProjectAmender amender) { amender.LogAllPublicMethods(); }

        #endregion
    }
}
