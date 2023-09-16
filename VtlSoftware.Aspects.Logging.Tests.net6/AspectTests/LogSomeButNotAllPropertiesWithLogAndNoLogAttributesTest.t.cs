using System;
using VtlSoftware.Aspects.Logging.Net6;
namespace VtlSoftware.Aspects.Logging.Tests.net6.LogSomeButNotAllPropertiesWithLogAndNoLogAttributes
{
    public class LogSomeButNotAllPropertiesWithLogAndNoLogAttributesTest
    {
        [NoLog]
        public DateTime MyDate { get; set; }
        private double _myDouble;
        [Log]
        public double MyDouble
        {
            get
            {
                var propValue = this._myDouble;
                var result = this._myDouble;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of LogSomeButNotAllPropertiesWithLogAndNoLogAttributesTest.MyDouble is: double = {propValue}");
                return (global::System.Double)result;
            }
            set
            {
                var oldPropValue = this._myDouble;
                this._myDouble = value;
                var newPropValue = this._myDouble;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogSomeButNotAllPropertiesWithLogAndNoLogAttributesTest.MyDouble was: double = {oldPropValue}");
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogSomeButNotAllPropertiesWithLogAndNoLogAttributesTest.MyDouble is: double = {newPropValue}");
            }
        }
        [NoLog]
        public int MyInt { get; set; }
        private string _myString = default!;
        [Log]
        public string MyString
        {
            get
            {
                var propValue = this._myString;
                var result = this._myString;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of LogSomeButNotAllPropertiesWithLogAndNoLogAttributesTest.MyString is: string = {propValue}");
                return (global::System.String)result;
            }
            set
            {
                var oldPropValue = this._myString;
                this._myString = value;
                var newPropValue = this._myString;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogSomeButNotAllPropertiesWithLogAndNoLogAttributesTest.MyString was: string = {oldPropValue}");
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogSomeButNotAllPropertiesWithLogAndNoLogAttributesTest.MyString is: string = {newPropValue}");
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public LogSomeButNotAllPropertiesWithLogAndNoLogAttributesTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogSomeButNotAllPropertiesWithLogAndNoLogAttributes.LogSomeButNotAllPropertiesWithLogAndNoLogAttributesTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogSomeButNotAllPropertiesWithLogAndNoLogAttributes.LogSomeButNotAllPropertiesWithLogAndNoLogAttributesTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
    }
}