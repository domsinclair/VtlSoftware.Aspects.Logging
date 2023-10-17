using System;
using VtlSoftware.Aspects.Logging.Net6;
namespace VtlSoftware.Aspects.Logging.Tests.net6.LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributes
{
    public class LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributesTest
    {
        [NoLog]
        public DateTime MyDate { get; set; }
        private double _myDouble;
        [LogAndTime]
        public double MyDouble
        {
            get
            {
                var result = this._myDouble;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The value of LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributesTest.MyDouble is: double = {this._myDouble}");
                return (global::System.Double)result;
            }
            set
            {
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The old value of LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributesTest was: double = {this._myDouble}");
                this._myDouble = value;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The new value of LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributesTest is: double = {this._myDouble}");
            }
        }
        [NoLog]
        public int MyInt { get; set; }
        private string _myString = default!;
        [LogAndTime]
        public string MyString
        {
            get
            {
                var result = this._myString;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The value of LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributesTest.MyString is: string = {this._myString}");
                return (global::System.String)result;
            }
            set
            {
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The old value of LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributesTest was: string = {this._myString}");
                this._myString = value;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The new value of LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributesTest is: string = {this._myString}");
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        private global::VtlSoftware.Aspects.Logging.Net6.ILoggingApect loggingApect;
        public LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributesTest(global::VtlSoftware.Aspects.Logging.Net6.ILoggingApect? loggingApect = default(global::VtlSoftware.Aspects.Logging.Net6.ILoggingApect?), global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributes.LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributesTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributes.LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributesTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            this.loggingApect = loggingApect ?? throw new System.ArgumentNullException(nameof(loggingApect));
        }
    }
}