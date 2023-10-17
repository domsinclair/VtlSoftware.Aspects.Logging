using Metalama.Framework.Fabrics;
using System;
using VtlSoftware.Aspects.Logging.Net6;
namespace VtlSoftware.Aspects.Logging.Tests.net6.LogAllProperties
{
    public class LogAllPropertiesTest
    {
        public LogAllPropertiesTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogAllProperties.LogAllPropertiesTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogAllProperties.LogAllPropertiesTest>), global::VtlSoftware.Aspects.Logging.Net6.ILoggingApect? loggingApect = default(global::VtlSoftware.Aspects.Logging.Net6.ILoggingApect?))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            this.loggingApect = loggingApect ?? throw new System.ArgumentNullException(nameof(loggingApect));
        }
        private DateTime _myDateTime;
        public DateTime MyDateTime
        {
            get
            {
                var result = this._myDateTime;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The value of LogAllPropertiesTest.MyDateTime is: DateTime = {this._myDateTime}");
                return (global::System.DateTime)result;
            }
            set
            {
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The old value of LogAllPropertiesTest was: DateTime = {this._myDateTime}");
                this._myDateTime = value;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The new value of LogAllPropertiesTest is: DateTime = {this._myDateTime}");
            }
        }
        private decimal _myDecimal;
        public decimal MyDecimal
        {
            get
            {
                var result = this._myDecimal;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The value of LogAllPropertiesTest.MyDecimal is: decimal = {this._myDecimal}");
                return (global::System.Decimal)result;
            }
            set
            {
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The old value of LogAllPropertiesTest was: decimal = {this._myDecimal}");
                this._myDecimal = value;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The new value of LogAllPropertiesTest is: decimal = {this._myDecimal}");
            }
        }
        private double _myDouble;
        public double MyDouble
        {
            get
            {
                var result = this._myDouble;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The value of LogAllPropertiesTest.MyDouble is: double = {this._myDouble}");
                return (global::System.Double)result;
            }
            set
            {
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The old value of LogAllPropertiesTest was: double = {this._myDouble}");
                this._myDouble = value;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The new value of LogAllPropertiesTest is: double = {this._myDouble}");
            }
        }
        private int _myInteger;
        public int MyInteger
        {
            get
            {
                var result = this._myInteger;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The value of LogAllPropertiesTest.MyInteger is: int = {this._myInteger}");
                return (global::System.Int32)result;
            }
            set
            {
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The old value of LogAllPropertiesTest was: int = {this._myInteger}");
                this._myInteger = value;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The new value of LogAllPropertiesTest is: int = {this._myInteger}");
            }
        }
        private string _myString1 = default!;
        public string myString
        {
            get
            {
                var result = this._myString1;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The value of LogAllPropertiesTest.myString is: string = {this._myString1}");
                return (global::System.String)result;
            }
            set
            {
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The old value of LogAllPropertiesTest was: string = {this._myString1}");
                this._myString1 = value;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The new value of LogAllPropertiesTest is: string = {this._myString1}");
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        private global::VtlSoftware.Aspects.Logging.Net6.ILoggingApect loggingApect;
    }
#pragma warning disable CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
    public class Configure : ProjectFabric
    {
        public override void AmendProject(IProjectAmender amender) => throw new System.NotSupportedException("Compile-time-only code cannot be called at run-time.");
    }
#pragma warning restore CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
}