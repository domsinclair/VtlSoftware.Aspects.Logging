
using Metalama.Extensions.DependencyInjection;
using Metalama.Framework.Advising;
using Metalama.Framework.Aspects;
using Metalama.Framework.Code;
using Metalama.Framework.Eligibility;
using Microsoft.Extensions.Logging;
using VtlSoftware.Aspects.Common.Net6;

namespace VtlSoftware.Aspects.Logging.Net6
{
    /// <summary>
    /// Attribute for log.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <seealso cref="T:Attribute"/>
    /// <seealso cref="T:IAspect{IMethod}"/>
    /// <seealso cref="T:IAspect{IFieldOrProperty}"/>

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
    public class LogAttribute : Attribute, IAspect<IMethod>, IAspect<IFieldOrProperty>
    {
        #region Fields

        /// <summary>
        /// (Immutable) The logger.
        /// </summary>
        [IntroduceDependency]
        private readonly ILogger logger;

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

        public void BuildAspect(IAspectBuilder<IMethod> builder)
        {
            if(!(builder.Target.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any() ||
                builder.Target.Attributes.OfAttributeType(typeof(LogAndTimeAttribute)).Any() ||
                builder.Target.DeclaringType.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any()))
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

        public void BuildAspect(IAspectBuilder<IFieldOrProperty> builder)
        {
            if(!(builder.Target.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any() ||
                builder.Target.DeclaringType.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any()))
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
        /// <seealso cref="M:IEligible.BuildEligibility(IEligibilityBuilder{IMethod})"/>
        /// <seealso href="@eligibility"/>

        public void BuildEligibility(IEligibilityBuilder<IMethod> builder)
        {
            EligibilityRuleFactory.GetAdviceEligibilityRule(AdviceKind.OverrideMethod);
            builder.MustNotBeStatic();
            builder.MustNotHaveAspectOfType(typeof(LogAndTimeAttribute));
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
        /// <seealso cref="M:IEligible.BuildEligibility(IEligibilityBuilder{IFieldOrProperty})"/>
        /// <seealso href="@eligibility"/>

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

        [Template]
        public dynamic? OverrideMethod()
        {
            var methodName = $"{meta.Target.Type.ToDisplayString(CodeDisplayFormat.MinimallyQualified)}.{meta.Target.Method.Name}";
            int paramCount = meta.Target.Parameters.Count;
            const string redacted = "<Redacted>";

            //add a check to see if we do actually want to do any logging at all
            var isLoggingEnabled = this.logger.IsEnabled(LogLevel.Trace) |
                this.logger.IsEnabled(LogLevel.Debug) |
                this.logger.IsEnabled(LogLevel.Information);

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
                                    if(SensitiveDataFilter.IsSensitive(p))
                                    {
                                        parameters.Add($"Type = {p.Type}: Parameter Name ={p.Name}", redacted);
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
                                if(SensitiveDataFilter.IsSensitive(meta.Target.Method.ReturnParameter))
                                {
                                    logger.Log(
                                        LogLevel.Information,
                                        $"Leaving {methodName} with the following result which has been {redacted}");
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
                var propertyName = $"{meta.Target.Type.ToDisplayString(CodeDisplayFormat.MinimallyQualified)}.{meta.Target.Property.Name}";
                var propType = meta.Target.Property.Type;
                var propValue = meta.Target.Property.Value;
                var result = meta.Proceed();
                logger.Log(LogLevel.Information, $"The value of {propertyName} is: {propType} = {propValue}");
                return result;
            }
            set
            {
                var propertyName = $"{meta.Target.Type.ToDisplayString(CodeDisplayFormat.MinimallyQualified)}.{meta.Target.Property.Name}";
                var propType = meta.Target.Property.Type;
                var oldPropValue = meta.Target.Property.Value;
                meta.Proceed();
                var newPropValue = meta.Target.Property.Value;
                logger.Log(LogLevel.Information, $"The old value of {propertyName} was: {propType} = {oldPropValue}");
                logger.Log(LogLevel.Information, $"The new value of {propertyName} is: {propType} = {newPropValue}");
            }
        }

        #endregion
    }
}
