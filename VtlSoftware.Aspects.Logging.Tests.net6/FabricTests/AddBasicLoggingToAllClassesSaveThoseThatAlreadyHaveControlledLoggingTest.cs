using Metalama.Framework.Fabrics;
using VtlSoftware.Aspects.Logging;

namespace VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveControlledLogging
{
    public class AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveControlledLoggingTest
    {
    }

    public class Test1
    {
    }

    internal class Test2
    {
    }

    [InjectControlledLogging]
    public class Test3
    {
    }

    public class Configure : ProjectFabric
    {
        #region Public Methods

        public override void AmendProject(IProjectAmender amender) { amender.AddBasicLoggingToAllClasses(); }

        #endregion
    }
}
