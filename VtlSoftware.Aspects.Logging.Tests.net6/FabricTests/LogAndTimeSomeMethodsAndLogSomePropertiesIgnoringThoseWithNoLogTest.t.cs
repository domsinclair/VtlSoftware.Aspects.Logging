using Metalama.Framework.Fabrics;
using System;
using VtlSoftware.Aspects.Logging.Net6;
namespace VtlSoftware.Aspects.Logging.Tests.net6.LogAndTimeSomeMethodsAndLogSomePropertiesIgnoringThoseWithNoLog
{
    public class LogAndTimeSomeMethodsAndLogSomePropertiesIgnoringThoseWithNoLogTest
    {
        public LogAndTimeSomeMethodsAndLogSomePropertiesIgnoringThoseWithNoLogTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogAndTimeSomeMethodsAndLogSomePropertiesIgnoringThoseWithNoLog.LogAndTimeSomeMethodsAndLogSomePropertiesIgnoringThoseWithNoLogTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogAndTimeSomeMethodsAndLogSomePropertiesIgnoringThoseWithNoLog.LogAndTimeSomeMethodsAndLogSomePropertiesIgnoringThoseWithNoLogTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
        public DateTime GetTodaysDate()
        {
            const string redacted = "<Redacted>";
           var isLoggingEnabled = this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace) | this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug) | this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Information);
            if (isLoggingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Entering LogAndTimeSomeMethodsAndLogSomePropertiesIgnoringThoseWithNoLogTest.GetTodaysDate.");
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
                    using (var guard_1 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving LogAndTimeSomeMethodsAndLogSomePropertiesIgnoringThoseWithNoLogTest.GetTodaysDate with the following result: {result}");
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
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occurred in LogAndTimeSomeMethodsAndLogSomePropertiesIgnoringThoseWithNoLogTest.GetTodaysDate. These are the details: {e}");
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
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"LogAndTimeSomeMethodsAndLogSomePropertiesIgnoringThoseWithNoLogTest.GetTodaysDate took {millisecs} ms to complete.");
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
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of LogAndTimeSomeMethodsAndLogSomePropertiesIgnoringThoseWithNoLogTest.MyDate is: DateTime? = {propValue}");
                return (global::System.DateTime?)result;
            }
            set
            {
                var oldPropValue = this._myDate;
                this._myDate = value;
                var newPropValue = this._myDate;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogAndTimeSomeMethodsAndLogSomePropertiesIgnoringThoseWithNoLogTest.MyDate was: DateTime? = {oldPropValue}");
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogAndTimeSomeMethodsAndLogSomePropertiesIgnoringThoseWithNoLogTest.MyDate is: DateTime? = {newPropValue}");
            }
        }
        private double _myDouble1;
        public double myDouble
        {
            get
            {
                var propValue = this._myDouble1;
                var result = this._myDouble1;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of LogAndTimeSomeMethodsAndLogSomePropertiesIgnoringThoseWithNoLogTest.myDouble is: double = {propValue}");
                return (global::System.Double)result;
            }
            set
            {
                var oldPropValue = this._myDouble1;
                this._myDouble1 = value;
                var newPropValue = this._myDouble1;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogAndTimeSomeMethodsAndLogSomePropertiesIgnoringThoseWithNoLogTest.myDouble was: double = {oldPropValue}");
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogAndTimeSomeMethodsAndLogSomePropertiesIgnoringThoseWithNoLogTest.myDouble is: double = {newPropValue}");
            }
        }
        [NoLog]
        public string mystring { get; set; }
        private global::Microsoft.Extensions.Logging.ILogger logger;
    }
#pragma warning disable CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
    public class Configure : ProjectFabric
    {
        public override void AmendProject(IProjectAmender amender) => throw new System.NotSupportedException("Compile-time-only code cannot be called at run-time.");
    }
#pragma warning restore CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
}