// Warning VTL101 on `LogClass`: `This class has already had aspects applied to it (possibly via a fabric) that have introduced the ILogger interface via Dependency Ijection. You will be able to add your own custom log messages. Remove the [InjectBasicLogging] Aspect`
// Warning VTL101 on `LogAnTimeClassClass`: `This class has already had aspects applied to it (possibly via a fabric) that have introduced the ILogger interface via Dependency Ijection. You will be able to add your own custom log messages. Remove the [InjectBasicLogging] Aspect`
using Metalama.Framework.Fabrics;
using VtlSoftware.Aspects.Logging.Net6;
namespace VtlSoftware.Aspects.Logging.Tests.net6.AddontrolledLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThem
{
    public class AddontrolledLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThemTest
    {
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public AddontrolledLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThemTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddontrolledLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThem.AddontrolledLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThemTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddontrolledLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThem.AddontrolledLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThemTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
    }
    public class Test1
    {
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public Test1(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddontrolledLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThem.Test1> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddontrolledLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThem.Test1>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
    }
    internal class Test2
    {
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public Test2(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddontrolledLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThem.Test2> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddontrolledLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThem.Test2>))
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
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The value of LogClass.MyString is: string = {this._myString}");
                return (global::System.String)result;
            }
            set
            {
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The old value of LogClass was: string = {this._myString}");
                this._myString = value;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The new value of LogClass is: string = {this._myString}");
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        private global::VtlSoftware.Aspects.Logging.Net6.ILoggingApect loggingApect;
        public LogClass(global::VtlSoftware.Aspects.Logging.Net6.ILoggingApect? loggingApect = default(global::VtlSoftware.Aspects.Logging.Net6.ILoggingApect?), global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddontrolledLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThem.LogClass> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddontrolledLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThem.LogClass>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            this.loggingApect = loggingApect ?? throw new System.ArgumentNullException(nameof(loggingApect));
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
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The value of LogAnTimeClassClass.MyString is: string = {this._myString}");
                return (global::System.String)result;
            }
            set
            {
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The old value of LogAnTimeClassClass was: string = {this._myString}");
                this._myString = value;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The new value of LogAnTimeClassClass is: string = {this._myString}");
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        private global::VtlSoftware.Aspects.Logging.Net6.ILoggingApect loggingApect;
        public LogAnTimeClassClass(global::VtlSoftware.Aspects.Logging.Net6.ILoggingApect? loggingApect = default(global::VtlSoftware.Aspects.Logging.Net6.ILoggingApect?), global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddontrolledLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThem.LogAnTimeClassClass> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.AddontrolledLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThem.LogAnTimeClassClass>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            this.loggingApect = loggingApect ?? throw new System.ArgumentNullException(nameof(loggingApect));
        }
    }
#pragma warning disable CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
    public class Configure : ProjectFabric
    {
        public override void AmendProject(IProjectAmender amender) => throw new System.NotSupportedException("Compile-time-only code cannot be called at run-time.");
    }
#pragma warning restore CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
}