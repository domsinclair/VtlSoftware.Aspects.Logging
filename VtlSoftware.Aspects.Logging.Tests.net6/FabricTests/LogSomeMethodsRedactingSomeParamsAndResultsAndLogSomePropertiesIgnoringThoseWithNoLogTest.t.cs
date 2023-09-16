using Metalama.Framework.Fabrics;
using System;
using VtlSoftware.Aspects.Logging.Net6;
namespace VtlSoftware.Aspects.Logging.Tests.net6.LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLog
{
    public class LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest
    {
        private Boolean TestPasswordValidity([Redact] String password)
        {
            const string redacted = "<Redacted>";
            var isTracingEnabled = this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace);
            if (isTracingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object> parameters = new();
                        parameters.Add("Type = string: Parameter Name =password", redacted);
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Entering LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.TestPasswordValidity with these parameters: {parameters}");
                    }
                }
            }
            try
            {
                global::System.Boolean result;
                //do stuff
                result = true;
                if (isTracingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.TestPasswordValidity with the following result: {result}");
                        }
                    }
                }
                return (global::System.Boolean)result;
            }
            catch (global::System.Exception e) when (this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                using (var guard_2 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard_2.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occured in LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.TestPasswordValidity. These are the details: {e}");
                    }
                }
                throw;
            }
        }
        public DateTime GetTodaysDate()
        {
            const string redacted = "<Redacted>";
            var isTracingEnabled = this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace);
            if (isTracingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Entering LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.GetTodaysDate.");
                    }
                }
            }
            try
            {
                global::System.DateTime result;
                result = DateTime.Now;
                if (isTracingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.GetTodaysDate with the following result: {result}");
                        }
                    }
                }
                return (global::System.DateTime)result;
            }
            catch (global::System.Exception e) when (this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                using (var guard_2 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard_2.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occured in LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.GetTodaysDate. These are the details: {e}");
                    }
                }
                throw;
            }
        }
        [return: Redact]
        public double SecretAddition(double a, double b)
        {
            const string redacted = "<Redacted>";
            var isTracingEnabled = this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace);
            if (isTracingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object> parameters = new();
                        parameters.Add("Type = double: Parameter Name = a", a);
                        parameters.Add("Type = double: Parameter Name = b", b);
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Entering LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.SecretAddition with these parameters: {parameters}");
                    }
                }
            }
            try
            {
                global::System.Double result;
                result = a + b;
                if (isTracingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.SecretAddition with the following result which has been {redacted}");
                        }
                    }
                }
                return (global::System.Double)result;
            }
            catch (global::System.Exception e) when (this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                using (var guard_2 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard_2.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occured in LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.SecretAddition. These are the details: {e}");
                    }
                }
                throw;
            }
        }
        [NoLog]
        public string TrimString(string myString)
        {
            return myString.Trim();
        }
        private DateTime? _myDate;
        public DateTime? MyDate
        {
            get
            {
                var propValue = this._myDate;
                var result = this._myDate;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.MyDate is: DateTime? = {propValue}");
                return (global::System.DateTime?)result;
            }
            set
            {
                var oldPropValue = this._myDate;
                this._myDate = value;
                var newPropValue = this._myDate;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.MyDate was: DateTime? = {oldPropValue}");
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.MyDate is: DateTime? = {newPropValue}");
            }
        }
        private double _myDouble1;
        public double myDouble
        {
            get
            {
                var propValue = this._myDouble1;
                var result = this._myDouble1;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.myDouble is: double = {propValue}");
                return (global::System.Double)result;
            }
            set
            {
                var oldPropValue = this._myDouble1;
                this._myDouble1 = value;
                var newPropValue = this._myDouble1;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.myDouble was: double = {oldPropValue}");
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.myDouble is: double = {newPropValue}");
            }
        }
        [NoLog]
        public string mystring { get; set; }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLog.LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLog.LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
    }
#pragma warning disable CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
    public class Configure : ProjectFabric
    {
        public override void AmendProject(IProjectAmender amender) => throw new System.NotSupportedException("Compile-time-only code cannot be called at run-time.");
    }
#pragma warning restore CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
}