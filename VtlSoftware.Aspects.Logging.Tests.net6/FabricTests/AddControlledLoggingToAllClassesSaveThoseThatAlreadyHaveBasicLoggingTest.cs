using Metalama.Framework.Fabrics;
using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.Logging.Tests.net6.AddControlledLoggingToAllClassesSaveThoseThatAlreadyHaveBasicLogging
{
    public class AddControlledLoggingToAllClassesSaveThoseThatAlreadyHaveBasicLoggingTest
    {
    }

    public class Test1
    {
    }

    internal class Test2
    {
    }

    [InjectBasicLogging]
    public class Test3
    {
    }

    public class Configure : ProjectFabric
    {
        #region Public Methods

        public override void AmendProject(IProjectAmender amender) { amender.AddControlledLoggingToAllClasses(); }

        #endregion
    }
}
