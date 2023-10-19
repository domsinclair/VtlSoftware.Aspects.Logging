using Metalama.Framework.Fabrics;
using VtlSoftware.Aspects.Logging;
namespace VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClasses
{
    public class AddBasicLoggingToAllClassesTest
    {
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public AddBasicLoggingToAllClassesTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClasses.AddBasicLoggingToAllClassesTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClasses.AddBasicLoggingToAllClassesTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
    }
    public class Test1
    {
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public Test1(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClasses.Test1> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClasses.Test1>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
    }
    internal class Test2
    {
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public Test2(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClasses.Test2> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClasses.Test2>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
    }
#pragma warning disable CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
    public class Configure : ProjectFabric
    {
        public override void AmendProject(IProjectAmender amender) => throw new System.NotSupportedException("Compile-time-only code cannot be called at run-time.");
    }
#pragma warning restore CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
}