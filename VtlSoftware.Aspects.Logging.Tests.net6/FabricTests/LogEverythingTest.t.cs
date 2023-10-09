using Metalama.Framework.Fabrics;
using System;
using VtlSoftware.Aspects.Logging.Net6;
namespace VtlSoftware.Aspects.Logging.Tests.net6.FabricTests
{
    public class LogEverythingTest
    {
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
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Entering LogEverythingTest.GetTodaysDate.");
                    }
                }
            }
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
                            global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving LogEverythingTest.GetTodaysDate with the following result: {result}");
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
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occurred in LogEverythingTest.GetTodaysDate. These are the details: {e}");
                    }
                }
                throw;
            }
        }
        public string TrimString(string myString)
        {
            const string redacted = "<Redacted>";
            var isLoggingEnabled = this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace) | this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug) | this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Information);
            if (isLoggingEnabled)
            {
                using (var guard = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object> parameters = new();
                        parameters.Add("Type = string: Parameter Name = myString", myString);
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Entering LogEverythingTest.TrimString with these parameters: {parameters}");
                    }
                }
            }
            try
            {
                global::System.String result;
                result = myString.Trim();
                if (isLoggingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Aspects.Common.Net6.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving LogEverythingTest.TrimString with the following result: {result}");
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
                        global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occurred in LogEverythingTest.TrimString. These are the details: {e}");
                    }
                }
                throw;
            }
        }
        private DateTime? _myDate;
        public DateTime? MyDate
        {
            get
            {
                var propValue = this._myDate;
                var result = this._myDate;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of LogEverythingTest.MyDate is: DateTime? = {propValue}");
                return (global::System.DateTime?)result;
            }
            set
            {
                var oldPropValue = this._myDate;
                this._myDate = value;
                var newPropValue = this._myDate;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogEverythingTest.MyDate was: DateTime? = {oldPropValue}");
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogEverythingTest.MyDate is: DateTime? = {newPropValue}");
            }
        }
        private double _myDouble1;
        public double myDouble
        {
            get
            {
                var propValue = this._myDouble1;
                var result = this._myDouble1;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of LogEverythingTest.myDouble is: double = {propValue}");
                return (global::System.Double)result;
            }
            set
            {
                var oldPropValue = this._myDouble1;
                this._myDouble1 = value;
                var newPropValue = this._myDouble1;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogEverythingTest.myDouble was: double = {oldPropValue}");
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogEverythingTest.myDouble is: double = {newPropValue}");
            }
        }
        private string? _mystring1;
        public string? mystring
        {
            get
            {
                var propValue = this._mystring1;
                var result = this._mystring1;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of LogEverythingTest.mystring is: string? = {propValue}");
                return (global::System.String?)result;
            }
            set
            {
                var oldPropValue = this._mystring1;
                this._mystring1 = value;
                var newPropValue = this._mystring1;
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of LogEverythingTest.mystring was: string? = {oldPropValue}");
                global::VtlSoftware.Aspects.Common.Net6.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of LogEverythingTest.mystring is: string? = {newPropValue}");
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        private global::VtlSoftware.Aspects.Logging.Net6.ILoggingApects loggingApects;
        public LogEverythingTest(global::VtlSoftware.Aspects.Logging.Net6.ILoggingApects? loggingApects = default(global::VtlSoftware.Aspects.Logging.Net6.ILoggingApects?), global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.FabricTests.LogEverythingTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Aspects.Logging.Tests.net6.FabricTests.LogEverythingTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            this.loggingApects = loggingApects ?? throw new System.ArgumentNullException(nameof(loggingApects));
        }
    }
#pragma warning disable CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
    public class Configure : ProjectFabric
    {
        public override void AmendProject(IProjectAmender amender) => throw new System.NotSupportedException("Compile-time-only code cannot be called at run-time.");
    }
#pragma warning restore CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
}