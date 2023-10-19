using System;
using VtlSoftware.Aspects.Logging;
namespace VtlSoftware.Aspects.Logging.Tests.net6.LogSomeButNotAllPropertiesWithLogAndNoLogAttributes
{
    public class LogSomeButNotAllPropertiesWithLogAndNoLogAttributesTest
    {
        [NoLog]
        public DateTime MyDate
        {
            get; set;
        }
        private double _myDouble;
        [Log]
        public double MyDouble
        {
            get
            {
                var result = this._myDouble;
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The value of LogSomeButNotAllPropertiesWithLogAndNoLogAttributesTest.MyDouble is: double = {this._myDouble}");
                return (global::System.Double)result;
            }
            set
            {
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The old value of LogSomeButNotAllPropertiesWithLogAndNoLogAttributesTest was: double = {this._myDouble}");
                this._myDouble = value;
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The new value of LogSomeButNotAllPropertiesWithLogAndNoLogAttributesTest is: double = {this._myDouble}");
            }
        }
        [NoLog]
        public int MyInt
        {
            get; set;
        }
        private string _myString = default!;
        [Log]
        public string MyString
        {
            get
            {
                var result = this._myString;
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The value of LogSomeButNotAllPropertiesWithLogAndNoLogAttributesTest.MyString is: string = {this._myString}");
                return (global::System.String)result;
            }
            set
            {
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The old value of LogSomeButNotAllPropertiesWithLogAndNoLogAttributesTest was: string = {this._myString}");
                this._myString = value;
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The new value of LogSomeButNotAllPropertiesWithLogAndNoLogAttributesTest is: string = {this._myString}");
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        private global::VtlSoftware.Aspects.Logging.ILoggingApect loggingApect;
        public LogSomeButNotAllPropertiesWithLogAndNoLogAttributesTest(global::VtlSoftware.Aspects.Logging.ILoggingApect? loggingApect = default(global::VtlSoftware.Aspects.Logging.ILoggingApect?), global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogSomeButNotAllPropertiesWithLogAndNoLogAttributes.LogSomeButNotAllPropertiesWithLogAndNoLogAttributesTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogSomeButNotAllPropertiesWithLogAndNoLogAttributes.LogSomeButNotAllPropertiesWithLogAndNoLogAttributesTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            this.loggingApect = loggingApect ?? throw new System.ArgumentNullException(nameof(loggingApect));
        }
    }
}