using Metalama.Framework.Fabrics;
using System;
using VtlSoftware.Aspects.Logging;
namespace VtlSoftware.Aspects.Logging.Tests.net6.LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLog
{
    public class LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest
    {
        private Boolean TestPasswordValidity([Redact] String password)
        {
            var isLoggingEnabled = this.loggingApect.LoggingEnabled;
            if (isLoggingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object> parameters = new();
                        parameters.Add("Type = string: Parameter Name =password", "Redacted");
                        global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Entering LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.TestPasswordValidity with these parameters: {parameters}");
                    }
                }
            }
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
                            global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.TestPasswordValidity with the following result: {result}");
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
                        global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occurred in LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.TestPasswordValidity. These are the details: {e}");
                    }
                }
                throw;
            }
        }
        public DateTime GetTodaysDate()
        {
            var isLoggingEnabled = this.loggingApect.LoggingEnabled;
            if (isLoggingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Entering LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.GetTodaysDate.");
                    }
                }
            }
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
                            global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.GetTodaysDate with the following result: {result}");
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
                        global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occurred in LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.GetTodaysDate. These are the details: {e}");
                    }
                }
                throw;
            }
        }
        [return: Redact]
        public double SecretAddition(double a, double b)
        {
            var isLoggingEnabled = this.loggingApect.LoggingEnabled;
            if (isLoggingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object> parameters = new();
                        parameters.Add("Type = double: Parameter Name = a", a);
                        parameters.Add("Type = double: Parameter Name = b", b);
                        global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Entering LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.SecretAddition with these parameters: {parameters}");
                    }
                }
            }
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
                            global::VtlSoftware.Aspects.Common.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Leaving LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.SecretAddition : The result has been redacted to protect sensitive data.");
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
                        global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occurred in LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.SecretAddition. These are the details: {e}");
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
                var result = this._myDate;
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The value of LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.MyDate is: DateTime? = {this._myDate}");
                return (global::System.DateTime?)result;
            }
            set
            {
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The old value of LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest was: DateTime? = {this._myDate}");
                this._myDate = value;
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The new value of LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest is: DateTime? = {this._myDate}");
            }
        }
        private double _myDouble1;
        public double myDouble
        {
            get
            {
                var result = this._myDouble1;
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The value of LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest.myDouble is: double = {this._myDouble1}");
                return (global::System.Double)result;
            }
            set
            {
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The old value of LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest was: double = {this._myDouble1}");
                this._myDouble1 = value;
                global::VtlSoftware.Aspects.Common.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Debug, $"The new value of LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest is: double = {this._myDouble1}");
            }
        }
        [NoLog]
        public string mystring
        {
            get; set;
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        private global::VtlSoftware.Aspects.Logging.ILoggingApect loggingApect;
        public LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest(global::VtlSoftware.Aspects.Logging.ILoggingApect? loggingApect = default(global::VtlSoftware.Aspects.Logging.ILoggingApect?), global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLog.LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLog.LogSomeMethodsRedactingSomeParamsAndResultsAndLogSomePropertiesIgnoringThoseWithNoLogTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            this.loggingApect = loggingApect ?? throw new System.ArgumentNullException(nameof(loggingApect));
        }
    }
#pragma warning disable CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
    public class Configure : ProjectFabric
    {
        public override void AmendProject(IProjectAmender amender) => throw new System.NotSupportedException("Compile-time-only code cannot be called at run-time.");
    }
#pragma warning restore CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
}