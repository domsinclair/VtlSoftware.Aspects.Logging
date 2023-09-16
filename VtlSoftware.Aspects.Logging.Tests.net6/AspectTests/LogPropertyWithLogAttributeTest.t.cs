using VtlSoftware.Aspects.Logging.Net6;
namespace VtlSoftware.Aspects.Logging.Tests.net6.LogPropertyWithLogAttribute
{
    public class LogPropertyWithLogAttributeTest
    {
        private double _myDouble;
        [Log]
        public double MyDouble
        {
            get
            {
                var propValue = this._myDouble;
                var result = this._myDouble;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of LogPropertyWithLogAttributeTest.MyDouble is: double = {propValue}");
                return (global::System.Double)result;
            }
            set
            {
                var oldPropValue = this._myDouble;
                this._myDouble = value;
                var newPropValue = this._myDouble;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogPropertyWithLogAttributeTest.MyDouble was: double = {oldPropValue}");
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogPropertyWithLogAttributeTest.MyDouble is: double = {newPropValue}");
            }
        }
        private string _myString = default!;
        [Log]
        public string MyString
        {
            get
            {
                var propValue = this._myString;
                var result = this._myString;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of LogPropertyWithLogAttributeTest.MyString is: string = {propValue}");
                return (global::System.String)result;
            }
            set
            {
                var oldPropValue = this._myString;
                this._myString = value;
                var newPropValue = this._myString;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogPropertyWithLogAttributeTest.MyString was: string = {oldPropValue}");
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogPropertyWithLogAttributeTest.MyString is: string = {newPropValue}");
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public LogPropertyWithLogAttributeTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogPropertyWithLogAttribute.LogPropertyWithLogAttributeTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogPropertyWithLogAttribute.LogPropertyWithLogAttributeTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
    }
}