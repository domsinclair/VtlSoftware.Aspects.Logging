using Metalama.Framework.Fabrics;
using System;
using VtlSoftware.Aspects.Logging.Net6;
namespace VtlSoftware.Aspects.Logging.Tests.net6.LogAllProperties
{
    public class LogAllPropertiesTest
    {
        public LogAllPropertiesTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogAllProperties.LogAllPropertiesTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogAllProperties.LogAllPropertiesTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
        private DateTime _myDateTime;
        public DateTime MyDateTime
        {
            get
            {
                return this._myDateTime;
            }
            set
            {
                var oldPropValue = this._myDateTime;
                this._myDateTime = value;
                var newPropValue = this._myDateTime;
                global::Microsoft.Extensions.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogAllPropertiesTest.MyDateTime was: DateTime = {oldPropValue}");
                global::Microsoft.Extensions.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogAllPropertiesTest.MyDateTime is: DateTime = {newPropValue}");
            }
        }
        private decimal _myDecimal;
        public decimal MyDecimal
        {
            get
            {
                return this._myDecimal;
            }
            set
            {
                var oldPropValue = this._myDecimal;
                this._myDecimal = value;
                var newPropValue = this._myDecimal;
                global::Microsoft.Extensions.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogAllPropertiesTest.MyDecimal was: decimal = {oldPropValue}");
                global::Microsoft.Extensions.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogAllPropertiesTest.MyDecimal is: decimal = {newPropValue}");
            }
        }
        private double _myDouble;
        public double MyDouble
        {
            get
            {
                return this._myDouble;
            }
            set
            {
                var oldPropValue = this._myDouble;
                this._myDouble = value;
                var newPropValue = this._myDouble;
                global::Microsoft.Extensions.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogAllPropertiesTest.MyDouble was: double = {oldPropValue}");
                global::Microsoft.Extensions.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogAllPropertiesTest.MyDouble is: double = {newPropValue}");
            }
        }
        private int _myInteger;
        public int MyInteger
        {
            get
            {
                return this._myInteger;
            }
            set
            {
                var oldPropValue = this._myInteger;
                this._myInteger = value;
                var newPropValue = this._myInteger;
                global::Microsoft.Extensions.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogAllPropertiesTest.MyInteger was: int = {oldPropValue}");
                global::Microsoft.Extensions.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogAllPropertiesTest.MyInteger is: int = {newPropValue}");
            }
        }
        private string _myString1 = default!;
        public string myString
        {
            get
            {
                return this._myString1;
            }
            set
            {
                var oldPropValue = this._myString1;
                this._myString1 = value;
                var newPropValue = this._myString1;
                global::Microsoft.Extensions.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogAllPropertiesTest.myString was: string = {oldPropValue}");
                global::Microsoft.Extensions.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogAllPropertiesTest.myString is: string = {newPropValue}");
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
    }
#pragma warning disable CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
    public class Configure : ProjectFabric
    {
        public override void AmendProject(IProjectAmender amender) => throw new System.NotSupportedException("Compile-time-only code cannot be called at run-time.");
    }
#pragma warning restore CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
}