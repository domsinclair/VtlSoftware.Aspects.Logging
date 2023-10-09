using Metalama.Framework.Fabrics;
using System;
using VtlSoftware.Aspects.Logging.Net6;
namespace VtlSoftware.Aspects.Logging.Tests.net6.LogAllProperties
{
    public class LogAllPropertiesTest
    {
        public LogAllPropertiesTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogAllProperties.LogAllPropertiesTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogAllProperties.LogAllPropertiesTest>), global::VtlSoftware.Aspects.Logging.Net6.ILoggingApects? loggingApects = default(global::VtlSoftware.Aspects.Logging.Net6.ILoggingApects?))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            this.loggingApects = loggingApects ?? throw new System.ArgumentNullException(nameof(loggingApects));
        }
        private DateTime _myDateTime;
        public DateTime MyDateTime
        {
            get
            {
                var propValue = this._myDateTime;
                var result = this._myDateTime;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of LogAllPropertiesTest.MyDateTime is: DateTime = {propValue}");
                return (global::System.DateTime)result;
            }
            set
            {
                var oldPropValue = this._myDateTime;
                this._myDateTime = value;
                var newPropValue = this._myDateTime;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogAllPropertiesTest.MyDateTime was: DateTime = {oldPropValue}");
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogAllPropertiesTest.MyDateTime is: DateTime = {newPropValue}");
            }
        }
        private decimal _myDecimal;
        public decimal MyDecimal
        {
            get
            {
                var propValue = this._myDecimal;
                var result = this._myDecimal;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of LogAllPropertiesTest.MyDecimal is: decimal = {propValue}");
                return (global::System.Decimal)result;
            }
            set
            {
                var oldPropValue = this._myDecimal;
                this._myDecimal = value;
                var newPropValue = this._myDecimal;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogAllPropertiesTest.MyDecimal was: decimal = {oldPropValue}");
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogAllPropertiesTest.MyDecimal is: decimal = {newPropValue}");
            }
        }
        private double _myDouble;
        public double MyDouble
        {
            get
            {
                var propValue = this._myDouble;
                var result = this._myDouble;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of LogAllPropertiesTest.MyDouble is: double = {propValue}");
                return (global::System.Double)result;
            }
            set
            {
                var oldPropValue = this._myDouble;
                this._myDouble = value;
                var newPropValue = this._myDouble;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogAllPropertiesTest.MyDouble was: double = {oldPropValue}");
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogAllPropertiesTest.MyDouble is: double = {newPropValue}");
            }
        }
        private int _myInteger;
        public int MyInteger
        {
            get
            {
                var propValue = this._myInteger;
                var result = this._myInteger;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of LogAllPropertiesTest.MyInteger is: int = {propValue}");
                return (global::System.Int32)result;
            }
            set
            {
                var oldPropValue = this._myInteger;
                this._myInteger = value;
                var newPropValue = this._myInteger;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogAllPropertiesTest.MyInteger was: int = {oldPropValue}");
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogAllPropertiesTest.MyInteger is: int = {newPropValue}");
            }
        }
        private string _myString1 = default!;
        public string myString
        {
            get
            {
                var propValue = this._myString1;
                var result = this._myString1;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of LogAllPropertiesTest.myString is: string = {propValue}");
                return (global::System.String)result;
            }
            set
            {
                var oldPropValue = this._myString1;
                this._myString1 = value;
                var newPropValue = this._myString1;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogAllPropertiesTest.myString was: string = {oldPropValue}");
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogAllPropertiesTest.myString is: string = {newPropValue}");
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        private global::VtlSoftware.Aspects.Logging.Net6.ILoggingApects loggingApects;
    }
#pragma warning disable CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
    public class Configure : ProjectFabric
    {
        public override void AmendProject(IProjectAmender amender) => throw new System.NotSupportedException("Compile-time-only code cannot be called at run-time.");
    }
#pragma warning restore CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
}