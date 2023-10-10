using Metalama.Framework.Fabrics;
using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.Logging.Tests.net6.AddControlledLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectInThem
{
    public class AddControlledLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectInThemTest
    {
    }

    public class Test1
    {
    }

    internal class Test2
    {
    }

    public class LogClass
    {
        #region Private Methods
        [Log]
        private string GetMyString() { return "Hi"; }

        #endregion
    }

    public class LogAnTimeClassClass
    {
        #region Private Methods
        [LogAndTime]
        private string GetMyString() { return "Hi"; }

        #endregion
    }

    public class Configure : ProjectFabric
    {
        #region Public Methods

        public override void AmendProject(IProjectAmender amender) { amender.AddControlledLoggingToAllClasses(); }

        #endregion
    }
}
