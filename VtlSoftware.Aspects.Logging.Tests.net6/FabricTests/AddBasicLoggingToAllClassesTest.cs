using Metalama.Framework.Fabrics;
using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClasses
{
    public class AddBasicLoggingToAllClassesTest
    {
    }

    public class Test1
    {
    }

    internal class Test2
    {
    }

    public class Configure : ProjectFabric
    {
        #region Public Methods

        public override void AmendProject(IProjectAmender amender) { amender.AddBasicLoggingToAllClasses(); }

        #endregion
    }
}
