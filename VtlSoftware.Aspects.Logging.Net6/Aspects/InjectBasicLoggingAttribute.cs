

using Metalama.Extensions.DependencyInjection;
using Metalama.Framework.Advising;
using Metalama.Framework.Aspects;
using Metalama.Framework.Code;
using Metalama.Framework.Code.Collections;
using Metalama.Framework.CodeFixes;
using Metalama.Framework.Diagnostics;
using Metalama.Framework.Eligibility;
using Microsoft.Extensions.Logging;
using VtlSoftware.Aspects.Logging.Net6;

[assembly: AspectOrder(
    typeof(InjectControlledLoggingAttribute),
    typeof(InjectBasicLoggingAttribute),
    typeof(LogAttribute),
    typeof(LogAndTimeAttribute))]

#pragma warning disable CS0649,CS8602,  CS8604, CS8618, IDE0051
namespace VtlSoftware.Aspects.Logging.Net6
{
    /// <summary>
    /// Attribute for inject basic logging.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <seealso cref="T:Attribute"/>
    /// <seealso cref="T:IAspect{INamedType}"/>
    ///
    /// ### <remarks>.</remarks>

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class InjectBasicLoggingAttribute : Attribute, IAspect<INamedType>
    {
        #region Fields
        /// <summary>
        /// The vtl 101 error.
        /// </summary>
        private static DiagnosticDefinition<INamedType> vtl101Error = new(
            "VTL101",
            Severity.Warning,
            "This class has already had aspects applied to it (possibly via a fabric) that have introduced the ILogger interface via Dependency Ijection. You will be able to add your own custom log messages. Remove the [InjectBasicLogging] Aspect");

        /// <summary>
        /// The vtl 103 error.
        /// </summary>
        private static DiagnosticDefinition<INamedType> vtl103Error = new(
            "VTL103",
            Severity.Error,
            "This class has already been marked as not requiring logging. Remove the [InjectBasicLogging] Aspect");

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
        /// <seealso cref="M:IAspect.BuildAspect(IAspectBuilder{INamedType})"/>
        ///
        /// ### <remarks>.</remarks>

        public void BuildAspect(IAspectBuilder<INamedType> builder)
        {
            //if(builder.Target.Attributes.OfAttributeType(typeof(InjectBasicLoggingAttribute)).Any())
            //{
            if(builder.Target.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any())
            {
                builder.Diagnostics.Report(vtl103Error.WithArguments(builder.Target));
                builder.Diagnostics.Suggest(
                    CodeFixFactory.RemoveAttributes(
                        builder.Target,
                        typeof(InjectBasicLoggingAttribute),
                        "Remove Aspect | InjectBasicLogging"));
                builder.SkipAspect();
            }

            if(builder.Target.Methods.Any(m => m.Enhancements().HasAspect<LogAttribute>()) ||
                builder.Target.Methods.Any(m => m.Enhancements().HasAspect<LogAndTimeAttribute>()))
            {
                builder.Diagnostics.Report(vtl101Error.WithArguments(builder.Target));
                builder.Diagnostics.Suggest(
                    CodeFixFactory.RemoveAttributes(
                        builder.Target,
                        typeof(InjectBasicLoggingAttribute),
                        "Remove Aspect | InjectBasicLogging"));
                builder.SkipAspect();
            }

            if(builder.Target.Properties.Any(p => p.Enhancements().HasAspect<LogAttribute>()) ||
                builder.Target.Properties.Any(p => p.Enhancements().HasAspect<LogAndTimeAttribute>()))
            {
                builder.Diagnostics.Report(vtl101Error.WithArguments(builder.Target));
                builder.Diagnostics.Suggest(
                    CodeFixFactory.RemoveAttributes(
                        builder.Target,
                        typeof(InjectBasicLoggingAttribute),
                        "Remove Aspect | InjectBasicLogging"));
                builder.SkipAspect();
            }

            //}
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
        /// <seealso cref="M:IEligible.BuildEligibility(IEligibilityBuilder{INamedType})"/>
        ///
        /// ### <remarks>.</remarks>

        public void BuildEligibility(IEligibilityBuilder<INamedType> builder)
        {
            EligibilityRuleFactory.GetAdviceEligibilityRule(AdviceKind.ImplementInterface);
            builder.MustNotBeStatic();
            builder.MustNotHaveAspectOfType(typeof(InjectControlledLoggingAttribute));
            builder.MustNotHaveAspectOfType(typeof(NoLogAttribute));
        }

        #endregion
    }
}
