using Metalama.Framework.Fabrics;
using VtlSoftware.Aspects.Logging;

namespace VtlSoftware.Aspects.Logging.Tests.net6.LogAllMethodsInClassSaveForThoseWithLogAndTimeAspectThatMustPrevail
{
    public class LogAllMethodsInClassSaveForThoseWithLogAndTimeAspectThatMustPrevailTest
    {
        #region Private Methods

        private int Add(int a, int b) { return a + b; }

        private void DoSomething()
        {
        }

        [LogAndTime]
        private void LoopThrough1000Items()
        {
            for(int i = 0; i < 1000; i++)
            {
                //do something
            }
        }

        #endregion
    }

    public class Configure : ProjectFabric
    {
        #region Public Methods

        public override void AmendProject(IProjectAmender amender) { amender.LogAllMethods(); }

        #endregion
    }
}
