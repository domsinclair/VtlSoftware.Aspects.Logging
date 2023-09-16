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
                var propValue = this._myDouble;
                var result = this._myDouble;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributesTest.MyDouble is: double = {propValue}");
                return (global::System.Double)result;
            }
            set
            {
                var oldPropValue = this._myDouble;
                this._myDouble = value;
                var newPropValue = this._myDouble;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributesTest.MyDouble was: double = {oldPropValue}");
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributesTest.MyDouble is: double = {newPropValue}");
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
                var propValue = this._myString;
                var result = this._myString;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributesTest.MyString is: string = {propValue}");
                return (global::System.String)result;
            }
            set
            {
                var oldPropValue = this._myString;
                this._myString = value;
                var newPropValue = this._myString;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributesTest.MyString was: string = {oldPropValue}");
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributesTest.MyString is: string = {newPropValue}");
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributesTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributes.LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributesTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributes.LogSomeButNotAllPropertiesWithLogAndTimeAndNoLogAttributesTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
    }
}