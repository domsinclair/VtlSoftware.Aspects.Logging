using Metalama.Framework.Fabrics;
using VtlSoftware.Aspects.Logging;
namespace VtlSoftware.Aspects.Logging.Tests.net6.AddControlledLoggingToAllTestsSaveThoseThatAreStatic
{
    public class AddControlledLoggingToAllTestsSaveThoseThatAreStaticTest
    {
        private global::Microsoft.Extensions.Logging.ILogger logger;
        private global::VtlSoftware.Aspects.Logging.ILoggingApect loggingApect;
        public AddControlledLoggingToAllTestsSaveThoseThatAreStaticTest(global::VtlSoftware.Aspects.Logging.ILoggingApect? loggingApect = default(global::VtlSoftware.Aspects.Logging.ILoggingApect?), global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddControlledLoggingToAllTestsSaveThoseThatAreStatic.AddControlledLoggingToAllTestsSaveThoseThatAreStaticTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddControlledLoggingToAllTestsSaveThoseThatAreStatic.AddControlledLoggingToAllTestsSaveThoseThatAreStaticTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            this.loggingApect = loggingApect ?? throw new System.ArgumentNullException(nameof(loggingApect));
        }
    }
    public class Test1
    {
        private global::Microsoft.Extensions.Logging.ILogger logger;
        private global::VtlSoftware.Aspects.Logging.ILoggingApect loggingApect;
        public Test1(global::VtlSoftware.Aspects.Logging.ILoggingApect? loggingApect = default(global::VtlSoftware.Aspects.Logging.ILoggingApect?), global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddControlledLoggingToAllTestsSaveThoseThatAreStatic.Test1> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddControlledLoggingToAllTestsSaveThoseThatAreStatic.Test1>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            this.loggingApect = loggingApect ?? throw new System.ArgumentNullException(nameof(loggingApect));
        }
    }
    internal class Test2
    {
        private global::Microsoft.Extensions.Logging.ILogger logger;
        private global::VtlSoftware.Aspects.Logging.ILoggingApect loggingApect;
        public Test2(global::VtlSoftware.Aspects.Logging.ILoggingApect? loggingApect = default(global::VtlSoftware.Aspects.Logging.ILoggingApect?), global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddControlledLoggingToAllTestsSaveThoseThatAreStatic.Test2> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddControlledLoggingToAllTestsSaveThoseThatAreStatic.Test2>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            this.loggingApect = loggingApect ?? throw new System.ArgumentNullException(nameof(loggingApect));
        }
    }
    public static class Test3
    {
    }
    internal static class Test4
    {
    }
#pragma warning disable CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
    public class Configure : ProjectFabric
    {
        public override void AmendProject(IProjectAmender amender) => throw new System.NotSupportedException("Compile-time-only code cannot be called at run-time.");
    }
#pragma warning restore CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
}