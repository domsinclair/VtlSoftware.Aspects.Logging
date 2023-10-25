using Metalama.Framework.Fabrics;
using System;
using VtlSoftware.Aspects.Logging;
namespace VtlSoftware.Aspects.Logging.Tests.net6.LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLog
{
    public class LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest
    {
        private Boolean TestPasswordValidity([Redact] String password)
        {
            var isLoggingEnabled = this.loggingAspect.LoggingEnabled;
            if (isLoggingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object> parameters = new();
                        parameters.Add("Type = string: Parameter Name =password", "Redacted");
                        global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Entering LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.TestPasswordValidity with these parameters: {parameters}");
                    }
                }
            }
            global::System.Diagnostics.Stopwatch watch = global::System.Diagnostics.Stopwatch.StartNew();
            try
            {
                global::System.Boolean result;
                //do stuff
                result = true;
                if (isLoggingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.TestPasswordValidity with the following result: {result}");
                        }
                    }
                }
                return (global::System.Boolean)result;
            }
            catch (global::System.Exception e) when (this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                using (var guard_2 = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                {
                    if (guard_2.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occurred in LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.TestPasswordValidity. These are the details: {e}");
                    }
                }
                throw;
            }
            finally
            {
                watch.Stop();
                long millisecs = watch.ElapsedMilliseconds;
                using (var guard_3 = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                {
                    if (guard_3.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.TestPasswordValidity took {millisecs} ms to complete.");
                    }
                }
            }
        }
        public DateTime GetTodaysDate()
        {
            var isLoggingEnabled = this.loggingAspect.LoggingEnabled;
            if (isLoggingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Entering LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.GetTodaysDate.");
                    }
                }
            }
            global::System.Diagnostics.Stopwatch watch = global::System.Diagnostics.Stopwatch.StartNew();
            try
            {
                global::System.DateTime result;
                result = DateTime.Now;
                if (isLoggingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.GetTodaysDate with the following result: {result}");
                        }
                    }
                }
                return (global::System.DateTime)result;
            }
            catch (global::System.Exception e) when (this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                using (var guard_2 = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                {
                    if (guard_2.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occurred in LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.GetTodaysDate. These are the details: {e}");
                    }
                }
                throw;
            }
            finally
            {
                watch.Stop();
                long millisecs = watch.ElapsedMilliseconds;
                using (var guard_3 = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                {
                    if (guard_3.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.GetTodaysDate took {millisecs} ms to complete.");
                    }
                }
            }
        }
        [return: Redact]
        public double SecretAddition(double a, double b)
        {
            var isLoggingEnabled = this.loggingAspect.LoggingEnabled;
            if (isLoggingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object> parameters = new();
                        parameters.Add("Type = double: Parameter Name = a", a);
                        parameters.Add("Type = double: Parameter Name = b", b);
                        global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Entering LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.SecretAddition with these parameters: {parameters}");
                    }
                }
            }
            global::System.Diagnostics.Stopwatch watch = global::System.Diagnostics.Stopwatch.StartNew();
            try
            {
                global::System.Double result;
                result = a + b;
                if (isLoggingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Aspects.Common.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Leaving LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.SecretAddition : The result has been redacted to protect sensitive data.");
                        }
                    }
                }
                return (global::System.Double)result;
            }
            catch (global::System.Exception e) when (this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                using (var guard_2 = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                {
                    if (guard_2.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occurred in LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.SecretAddition. These are the details: {e}");
                    }
                }
                throw;
            }
            finally
            {
                watch.Stop();
                long millisecs = watch.ElapsedMilliseconds;
                using (var guard_3 = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                {
                    if (guard_3.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.SecretAddition took {millisecs} ms to complete.");
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
                var result = this._myDate;
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The value of LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.MyDate is: DateTime? = {this._myDate}");
                return (global::System.DateTime?)result;
            }
            set
            {
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The old value of LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest was: DateTime? = {this._myDate}");
                this._myDate = value;
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The new value of LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest is: DateTime? = {this._myDate}");
            }
        }
        private double _myDouble1;
        public double myDouble
        {
            get
            {
                var result = this._myDouble1;
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The value of LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.myDouble is: double = {this._myDouble1}");
                return (global::System.Double)result;
            }
            set
            {
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The old value of LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest was: double = {this._myDouble1}");
                this._myDouble1 = value;
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The new value of LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest is: double = {this._myDouble1}");
            }
        }
        [NoLog]
        public string mystring
        {
            get; set;
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        private global::VtlSoftware.Aspects.Logging.ILoggingAspect loggingAspect;
        public LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest(global::VtlSoftware.Aspects.Logging.ILoggingAspect? loggingAspect = default(global::VtlSoftware.Aspects.Logging.ILoggingAspect?), global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLog.LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLog.LogAndTimeSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            this.loggingAspect = loggingAspect ?? throw new System.ArgumentNullException(nameof(loggingAspect));
        }
    }
#pragma warning disable CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
    public class Configure : ProjectFabric
    {
        public override void AmendProject(IProjectAmender amender) => throw new System.NotSupportedException("Compile-time-only code cannot be called at run-time.");
    }
#pragma warning restore CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
}