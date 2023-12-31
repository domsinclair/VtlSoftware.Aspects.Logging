// Warning VTL101 on `LogClass`: `This class has already had aspects applied to it (possibly via a fabric) that have introduced the ILogger interface via Dependency Ijection. You will be able to add your own custom log messages. Remove the [InjectBasicLogging] Aspect`
// Warning VTL101 on `LogAnTimeClassClass`: `This class has already had aspects applied to it (possibly via a fabric) that have introduced the ILogger interface via Dependency Ijection. You will be able to add your own custom log messages. Remove the [InjectBasicLogging] Aspect`
using Metalama.Framework.Fabrics;
using VtlSoftware.Aspects.Logging;
namespace VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThem
{
    public class AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThemTest
    {
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThemTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThem.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThemTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThem.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThemTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
    }
    public class Test1
    {
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public Test1(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThem.Test1> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThem.Test1>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
    }
    internal class Test2
    {
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public Test2(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThem.Test2> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThem.Test2>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
    }
    public class LogClass
    {
        private string GetMyString()
        {
            return "Hi";
        }
        private string _myString = default!;
        [Log]
        public string MyString
        {
            get
            {
                var result = this._myString;
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The value of LogClass.MyString is: string = {this._myString}");
                return (global::System.String)result;
            }
            set
            {
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The old value of LogClass was: string = {this._myString}");
                this._myString = value;
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The new value of LogClass is: string = {this._myString}");
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        private global::VtlSoftware.Aspects.Logging.ILoggingAspect loggingAspect;
        public LogClass(global::VtlSoftware.Aspects.Logging.ILoggingAspect? loggingAspect = default(global::VtlSoftware.Aspects.Logging.ILoggingAspect?), global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThem.LogClass> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThem.LogClass>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            this.loggingAspect = loggingAspect ?? throw new System.ArgumentNullException(nameof(loggingAspect));
        }
    }
    public class LogAnTimeClassClass
    {
        private string GetMyString()
        {
            return "Hi";
        }
        private string _myString = default!;
        [LogAndTime]
        public string MyString
        {
            get
            {
                var result = this._myString;
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The value of LogAnTimeClassClass.MyString is: string = {this._myString}");
                return (global::System.String)result;
            }
            set
            {
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The old value of LogAnTimeClassClass was: string = {this._myString}");
                this._myString = value;
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The new value of LogAnTimeClassClass is: string = {this._myString}");
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        private global::VtlSoftware.Aspects.Logging.ILoggingAspect loggingAspect;
        public LogAnTimeClassClass(global::VtlSoftware.Aspects.Logging.ILoggingAspect? loggingAspect = default(global::VtlSoftware.Aspects.Logging.ILoggingAspect?), global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThem.LogAnTimeClassClass> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddBasicLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThem.LogAnTimeClassClass>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            this.loggingAspect = loggingAspect ?? throw new System.ArgumentNullException(nameof(loggingAspect));
        }
    }
#pragma warning disable CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
    public class Configure : ProjectFabric
    {
        public override void AmendProject(IProjectAmender amender) => throw new System.NotSupportedException("Compile-time-only code cannot be called at run-time.");
    }
#pragma warning restore CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
}