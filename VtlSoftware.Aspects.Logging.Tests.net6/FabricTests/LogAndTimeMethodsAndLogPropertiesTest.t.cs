using Metalama.Framework.Fabrics;
using System;
using VtlSoftware.Aspects.Logging.Net6;
namespace VtlSoftware.Aspects.Logging.Tests.net6.LogAndTimeMethodsAndLogProperties
{
    public class LogAndTimeMethodsAndLogPropertiesTest
    {
        public LogAndTimeMethodsAndLogPropertiesTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogAndTimeMethodsAndLogProperties.LogAndTimeMethodsAndLogPropertiesTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.LogAndTimeMethodsAndLogProperties.LogAndTimeMethodsAndLogPropertiesTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
        private void DoSomething()
        {
            const string redacted = "<Redacted>";
            var isTracingEnabled = this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace);
            if (isTracingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Entering LogAndTimeMethodsAndLogPropertiesTest.DoSomething.");
                    }
                }
            }
            global::System.Diagnostics.Stopwatch watch = global::System.Diagnostics.Stopwatch.StartNew();
            try
            {
                object result = null;
                if (isTracingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Leaving LogAndTimeMethodsAndLogPropertiesTest.DoSomething.");
                        }
                    }
                }
                return;
            }
            catch (global::System.Exception e) when (this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                using (var guard_2 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard_2.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occured in LogAndTimeMethodsAndLogPropertiesTest.DoSomething. These are the details: {e}");
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
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"LogAndTimeMethodsAndLogPropertiesTest.DoSomething took {millisecs} ms to complete.");
                    }
                }
            }
        }
        public void DoSomethingElse()
        {
            const string redacted = "<Redacted>";
            var isTracingEnabled = this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace);
            if (isTracingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Entering LogAndTimeMethodsAndLogPropertiesTest.DoSomethingElse.");
                    }
                }
            }
            global::System.Diagnostics.Stopwatch watch = global::System.Diagnostics.Stopwatch.StartNew();
            try
            {
                object result = null;
                if (isTracingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Leaving LogAndTimeMethodsAndLogPropertiesTest.DoSomethingElse.");
                        }
                    }
                }
                return;
            }
            catch (global::System.Exception e) when (this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                using (var guard_2 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard_2.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occured in LogAndTimeMethodsAndLogPropertiesTest.DoSomethingElse. These are the details: {e}");
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
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"LogAndTimeMethodsAndLogPropertiesTest.DoSomethingElse took {millisecs} ms to complete.");
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
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Entering LogAndTimeMethodsAndLogPropertiesTest.GetTodaysDate.");
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
                            global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving LogAndTimeMethodsAndLogPropertiesTest.GetTodaysDate with the following result: {result}");
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
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occured in LogAndTimeMethodsAndLogPropertiesTest.GetTodaysDate. These are the details: {e}");
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
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"LogAndTimeMethodsAndLogPropertiesTest.GetTodaysDate took {millisecs} ms to complete.");
                    }
                }
            }
        }
        public string TrimString(string myString)
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
                        parameters.Add("Type = string: Parameter Name = myString", myString);
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Entering LogAndTimeMethodsAndLogPropertiesTest.TrimString with these parameters: {parameters}");
                    }
                }
            }
            global::System.Diagnostics.Stopwatch watch = global::System.Diagnostics.Stopwatch.StartNew();
            try
            {
                global::System.String result;
                result = myString.Trim();
                if (isTracingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving LogAndTimeMethodsAndLogPropertiesTest.TrimString with the following result: {result}");
                        }
                    }
                }
                return (global::System.String)result;
            }
            catch (global::System.Exception e) when (this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                using (var guard_2 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard_2.CanLog)
                    {
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occured in LogAndTimeMethodsAndLogPropertiesTest.TrimString. These are the details: {e}");
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
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"LogAndTimeMethodsAndLogPropertiesTest.TrimString took {millisecs} ms to complete.");
                    }
                }
            }
        }
        private DateTime? _myDate;
        public DateTime? MyDate
        {
            get
            {
                var propValue = this._myDate;
                var result = this._myDate;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of LogAndTimeMethodsAndLogPropertiesTest.MyDate is: DateTime? = {propValue}");
                return (global::System.DateTime?)result;
            }
            set
            {
                var oldPropValue = this._myDate;
                this._myDate = value;
                var newPropValue = this._myDate;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogAndTimeMethodsAndLogPropertiesTest.MyDate was: DateTime? = {oldPropValue}");
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogAndTimeMethodsAndLogPropertiesTest.MyDate is: DateTime? = {newPropValue}");
            }
        }
        private double _myDouble1;
        public double myDouble
        {
            get
            {
                var propValue = this._myDouble1;
                var result = this._myDouble1;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of LogAndTimeMethodsAndLogPropertiesTest.myDouble is: double = {propValue}");
                return (global::System.Double)result;
            }
            set
            {
                var oldPropValue = this._myDouble1;
                this._myDouble1 = value;
                var newPropValue = this._myDouble1;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogAndTimeMethodsAndLogPropertiesTest.myDouble was: double = {oldPropValue}");
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogAndTimeMethodsAndLogPropertiesTest.myDouble is: double = {newPropValue}");
            }
        }
        private string _mystring1 = default!;
        public string mystring
        {
            get
            {
                var propValue = this._mystring1;
                var result = this._mystring1;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of LogAndTimeMethodsAndLogPropertiesTest.mystring is: string = {propValue}");
                return (global::System.String)result;
            }
            set
            {
                var oldPropValue = this._mystring1;
                this._mystring1 = value;
                var newPropValue = this._mystring1;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogAndTimeMethodsAndLogPropertiesTest.mystring was: string = {oldPropValue}");
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogAndTimeMethodsAndLogPropertiesTest.mystring is: string = {newPropValue}");
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