using Metalama.Framework.Fabrics;
using VtlSoftware.Aspects.Logging;

namespace VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllTestsSaveThoseThatAreStatic
{
    public class AddBasicLoggingToAllTestsSaveThoseThatAreStaticTest
    {
    }

    public class Test1
    {
    }

    internal class Test2
    {
    }

    public static class Test3
    {
    }

    internal static class Test4
    {
    }

    public class Configure : ProjectFabric
    {
        #region Public Methods

        public override void AmendProject(IProjectAmender amender) { amender.AddBasicLoggingToAllClasses(); }

        #endregion
    }
}
