using Metalama.Framework.Fabrics;
using System;
using VtlSoftware.Aspects.Logging.Net6;
namespace VtlSoftware.Aspects.Logging.Tests.net6.LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLog
{
    public class LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest
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
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Entering LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.TestPasswordValidity with these parameters: {parameters}");
                    }
                }
            }
            global::System.Diagnostics.Stopwatch watch = global::System.Diagnostics.Stopwatch.StartNew();
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
                            global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.TestPasswordValidity with the following result: {result}");
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
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occured in LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.TestPasswordValidity. These are the details: {e}");
                    }
                }
                throw;
            }
            finally
            {
                watch.Stop();
                long millisecs = watch.ElapsedMilliseconds;
                using (var guard_3 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard_3.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.TestPasswordValidity took {millisecs} ms to complete.");
                    }
                }
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
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Entering LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.GetTodaysDate.");
                    }
                }
            }
            global::System.Diagnostics.Stopwatch watch = global::System.Diagnostics.Stopwatch.StartNew();
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
                            global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.GetTodaysDate with the following result: {result}");
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
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occured in LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.GetTodaysDate. These are the details: {e}");
                    }
                }
                throw;
            }
            finally
            {
                watch.Stop();
                long millisecs = watch.ElapsedMilliseconds;
                using (var guard_3 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard_3.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.GetTodaysDate took {millisecs} ms to complete.");
                    }
                }
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
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Entering LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.SecretAddition with these parameters: {parameters}");
                    }
                }
            }
            global::System.Diagnostics.Stopwatch watch = global::System.Diagnostics.Stopwatch.StartNew();
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
                            global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.SecretAddition with the following result which has been {redacted}");
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
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occured in LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.SecretAddition. These are the details: {e}");
                    }
                }
                throw;
            }
            finally
            {
                watch.Stop();
                long millisecs = watch.ElapsedMilliseconds;
                using (var guard_3 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard_3.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.SecretAddition took {millisecs} ms to complete.");
                    }
                }
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
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.MyDate is: DateTime? = {propValue}");
                return (global::System.DateTime?)result;
            }
            set
            {
                var oldPropValue = this._myDate;
                this._myDate = value;
                var newPropValue = this._myDate;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.MyDate was: DateTime? = {oldPropValue}");
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.MyDate is: DateTime? = {newPropValue}");
            }
        }
        private double _myDouble1;
        public double myDouble
        {
            get
            {
                var propValue = this._myDouble1;
                var result = this._myDouble1;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.myDouble is: double = {propValue}");
                return (global::System.Double)result;
            }
            set
            {
                var oldPropValue = this._myDouble1;
                this._myDouble1 = value;
                var newPropValue = this._myDouble1;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.myDouble was: double = {oldPropValue}");
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.myDouble is: double = {newPropValue}");
            }
        }
        [NoLog]
        public string mystring { get; set; }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLog.LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLog.LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest>))
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