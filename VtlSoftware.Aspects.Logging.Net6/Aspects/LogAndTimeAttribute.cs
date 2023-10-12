
using Metalama.Extensions.DependencyInjection;
using Metalama.Framework.Advising;
using Metalama.Framework.Aspects;
using Metalama.Framework.Code;
using Metalama.Framework.CodeFixes;
using Metalama.Framework.Diagnostics;
using Metalama.Framework.Eligibility;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using VtlSoftware.Aspects.Common.Net6;

#pragma warning disable CS0649, CS8618, IDE0063
namespace VtlSoftware.Aspects.Logging.Net6
{
    /// <summary>
    /// Attribute for log and time.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <seealso cref="T:Attribute"/>
    /// <seealso cref="T:IAspect{IMethod}"/>
    /// <seealso cref="T:IAspect{IFieldOrProperty}"/>
    ///
    /// ### <remarks>
    /// An Aspect that will add basic logging to Methods and properties in a class.  It injects the
    /// Microsoft.Extensions.Logging ILogger interface and the VtlSoftware ILoggingAspect interface into the class and
    /// as such it cannot be used in a static class.
    /// </remarks>

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
    public class LogAndTimeAttribute : Attribute, IAspect<IMethod>, IAspect<IFieldOrProperty>
    {
        #region Fields

        /// <summary>
        /// The vtl 107 error.
        /// </summary>
        private static DiagnosticDefinition<IMethod> vtl107Error = new(
            "VTL107",
            Severity.Error,
            "This class has already been marked as not requiring logging. Remove the [LogAndTime] Aspect");

        /// <summary>
        /// The vtl 108 error.
        /// </summary>
        private static DiagnosticDefinition<IFieldOrProperty> vtl108Error = new(
            "VTL108",
            Severity.Error,
            "This class has already been marked as not requiring logging. Remove the [LogAndTime] Aspect");

        /// <summary>
        /// (Immutable) The logger.
        /// </summary>
        [IntroduceDependency]
        private readonly ILogger logger;

        /// <summary>
        /// (Immutable) The logging apect.
        /// </summary>
        [IntroduceDependency]
        private readonly ILoggingApect loggingApect;

        #endregion

        #region Public Methods
        /// <summary>
        /// Initializes the aspect. The implementation must add advice, child aspects and validators using the <paramref
        /// name="builder"/> parameter.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <param name="builder">
        /// An object that allows the aspect to add advice, child aspects and validators.
        /// </param>
        ///
        /// <seealso cref="M:IAspect.BuildAspect(IAspectBuilder{IMethod})"/>
        ///
        /// ### <remarks>.</remarks>

        public void BuildAspect(IAspectBuilder<IMethod> builder)
        {
            if(builder.Target.DeclaringType.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any())
            {
                builder.Diagnostics.Report(vtl107Error.WithArguments(builder.Target));
                builder.Diagnostics.Suggest(
                    CodeFixFactory.RemoveAttributes(
                        builder.Target,
                        typeof(LogAndTimeAttribute),
                        "Remove Aspect | LogAndTime"));
                builder.SkipAspect();
            }

            if(!(builder.Target.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any() ||
                builder.Target.Attributes.OfAttributeType(typeof(LogAttribute)).Any()))
            {
                builder.Advice.Override(builder.Target, nameof(this.OverrideMethod));
            } else
            {
                builder.SkipAspect();
            }
        }

        /// <summary>
        /// Initializes the aspect. The implementation must add advice, child aspects and validators using the <paramref
        /// name="builder"/> parameter.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <param name="builder">
        /// An object that allows the aspect to add advice, child aspects and validators.
        /// </param>
        ///
        /// <seealso cref="M:IAspect.BuildAspect(IAspectBuilder{IFieldOrProperty})"/>
        ///
        /// ### <remarks>.</remarks>

        public void BuildAspect(IAspectBuilder<IFieldOrProperty> builder)
        {
            if(builder.Target.DeclaringType.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any())
            {
                builder.Diagnostics.Report(vtl108Error.WithArguments(builder.Target));
                builder.Diagnostics.Suggest(
                    CodeFixFactory.RemoveAttributes(builder.Target, typeof(LogAndTimeAttribute), "Remove Aspect | Log"));
                builder.SkipAspect();
            }

            if(!(builder.Target.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any()))
            {
                builder.Advice.Override(builder.Target, nameof(this.OverrideProperty));
            } else
            {
                builder.SkipAspect();
            }
        }

        /// <summary>
        /// Configures the eligibility of the aspect or attribute. Implementations are not allowed to reference non-
        /// static members. Implementations must call the implementation of the base class if it exists.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <param name="builder">
        /// An object that allows the aspect to configure characteristics like description, dependencies, or layers.
        /// </param>
        ///
        /// <seealso href="@eligibility"/>
        /// <seealso cref="M:IEligible.BuildEligibility(IEligibilityBuilder{IMethod})"/>
        ///
        /// ### <remarks>.</remarks>

        public void BuildEligibility(IEligibilityBuilder<IMethod> builder)
        {
            EligibilityRuleFactory.GetAdviceEligibilityRule(AdviceKind.OverrideMethod);
            builder.MustNotBeStatic();
            builder.MustNotHaveAspectOfType(typeof(LogAttribute));
            builder.MustNotHaveAspectOfType(typeof(NoLogAttribute));
        }

        /// <summary>
        /// Configures the eligibility of the aspect or attribute. Implementations are not allowed to reference non-
        /// static members. Implementations must call the implementation of the base class if it exists.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <param name="builder">
        /// An object that allows the aspect to configure characteristics like description, dependencies, or layers.
        /// </param>
        ///
        /// <seealso href="@eligibility"/>
        /// <seealso cref="M:IEligible.BuildEligibility(IEligibilityBuilder{IFieldOrProperty})"/>
        ///
        /// ### <remarks>.</remarks>

        public void BuildEligibility(IEligibilityBuilder<IFieldOrProperty> builder)
        {
            EligibilityRuleFactory.GetAdviceEligibilityRule(AdviceKind.OverrideFieldOrPropertyOrIndexer);
            builder.MustNotBeStatic();
            builder.MustNotHaveAspectOfType(typeof(NoLogAttribute));
        }

        /// <summary>
        /// Override method.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <returns>A dynamic?</returns>
        ///
        /// ### <remarks>.</remarks>

        [Template]
        public dynamic? OverrideMethod()
        {
            var methodName = $"{meta.Target.Type.ToDisplayString(CodeDisplayFormat.MinimallyQualified)}.{meta.Target.Method.Name}";
            int paramCount = meta.Target.Parameters.Count;
            meta.Target.Project.TryGetProperty("SensitiveParameterNames", out var sensitiveParameterNames);

            // Add a check to see if we want to do any logging at all.
            // This value is obtained from an external configuration file (ie appsettings.json)

            var isLoggingEnabled = this.loggingApect.LoggingEnabled;

            if(isLoggingEnabled)
            {
                //add the entry message

                using(var guard = LogRecursionGuard.Begin())
                {
                    if(guard.CanLog)
                    {
                        if(paramCount == 0)
                        {
                            logger.LogString(LogLevel.Information, $"Entering {methodName}.");
                        } else
                        {
                            Dictionary<string, object> parameters = new();
                            foreach(var p in meta.Target.Parameters)
                            {
                                if(p.RefKind != RefKind.Out)
                                {
                                    if(SensitiveDataFilter.HasSensitiveParameters(p, sensitiveParameterNames))
                                    {
                                        parameters.Add($"Type = {p.Type}: Parameter Name ={p.Name}", "Redacted");
                                    } else
                                    {
                                        parameters.Add($"Type = {p.Type}: Parameter Name = {p.Name}", p.Value);
                                    }
                                } else
                                {
                                    //Metalama can't serialise an out parameter but it would help if we know it's there.
                                    parameters.Add(p.Name, " = <out>");
                                }
                            }
                            logger.Log(
                                LogLevel.Information,
                                $"Entering {methodName} with these parameters: {parameters}");
                        }
                    }
                }
            }
            Stopwatch watch = Stopwatch.StartNew();
            try
            {
                var result = meta.Proceed();
                if(isLoggingEnabled)
                {
                    // Display the success message which will be different when the method is void.
                    bool isVoid = meta.Target.Method.ReturnType.Is(typeof(void));

                    using(var guard = LogRecursionGuard.Begin())
                    {
                        if(guard.CanLog)
                        {
                            if(isVoid)
                            {
                                logger.LogString(LogLevel.Information, $"Leaving {methodName}.");
                            } else
                            {
                                if(SensitiveDataFilter.HasSensitiveParameters(
                                    meta.Target.Method.ReturnParameter,
                                    sensitiveParameterNames))
                                {
                                    logger.LogString(
                                        LogLevel.Information,
                                        $"Leaving {methodName} : The result has been redacted to protect sensitive data.");
                                } else
                                {
                                    logger.Log(
                                        LogLevel.Information,
                                        $"Leaving {methodName} with the following result: {result}");
                                }
                            }
                        }
                    }
                }
                return result;
            } catch(Exception e) when (this.logger.IsEnabled(LogLevel.Warning))
            {
                using(var guard = LogRecursionGuard.Begin())
                {
                    if(guard.CanLog)
                    {
                        logger.Log(LogLevel.Error, $"An error has occurred in {methodName}. These are the details: {e}");
                    }
                }
                throw;
            } finally
            {
                watch.Stop();
                long millisecs = watch.ElapsedMilliseconds;
                using(var guard = LogRecursionGuard.Begin())
                {
                    if(guard.CanLog)
                    {
                        logger.Log(LogLevel.Information, $"{methodName} took {millisecs} ms to complete.");
                    }
                }
            }
        }

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the override property.
        /// </summary>
        ///
        /// <value>The override property.</value>

        [Template]
        public dynamic? OverrideProperty
        {
            get
            {
                var result = meta.Proceed();
                logger.Log(
                    LogLevel.Debug,
                    $"The value of {meta.Target.Type.ToDisplayString(CodeDisplayFormat.MinimallyQualified)}.{meta.Target.Property.Name} is: {meta.Target.Property.Type} = {meta.Target.Property.Value}");
                return result;
            }
            set
            {
                logger.Log(
                    LogLevel.Debug,
                    $"The old value of {meta.Target.Type.ToDisplayString(CodeDisplayFormat.MinimallyQualified)} was: {meta.Target.Property.Type} = {meta.Target.Property.Value}");

                meta.Proceed();

                logger.Log(
                    LogLevel.Debug,
                    $"The new value of {meta.Target.Type.ToDisplayString(CodeDisplayFormat.MinimallyQualified)} is: {meta.Target.Property.Type} = {meta.Target.Property.Value}");
            }
        }

        #endregion
    }
}
