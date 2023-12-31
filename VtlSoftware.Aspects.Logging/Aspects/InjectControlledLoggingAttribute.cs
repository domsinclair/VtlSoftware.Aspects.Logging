﻿using Metalama.Extensions.DependencyInjection;
using Metalama.Framework.Advising;
using Metalama.Framework.Aspects;
using Metalama.Framework.Code;
using Metalama.Framework.CodeFixes;
using Metalama.Framework.Diagnostics;
using Metalama.Framework.Eligibility;
using Microsoft.Extensions.Logging;
using VtlSoftware.Aspects.Logging;

[assembly: AspectOrder(typeof(InjectControlledLoggingAttribute), typeof(InjectBasicLoggingAttribute))]

#pragma warning disable CS0649, CS8604, CS8618, IDE0051

namespace VtlSoftware.Aspects.Logging
{
    /// <summary>
    /// Attribute for inject controlled logging.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <seealso cref="T:Attribute"/>
    /// <seealso cref="T:IAspect{INamedType}"/>
    ///
    /// ### <remarks>.</remarks>

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class InjectControlledLoggingAttribute : Attribute, IAspect<INamedType>
    {
        #region Fields

        /// <summary>
        /// The vtl 101 error.
        /// </summary>
        private static DiagnosticDefinition<INamedType> vtl102Error = new(
            "VTL102",
            Severity.Warning,
            "This class has already had aspects applied to it (possibly via a fabric) that have introduced the ILogger and ILoggingAspect interfaces via Dependency Ijection. You will be able to add your own custom log messages. Remove the [InjectControlledLogging] Aspect");

        /// <summary>
        /// The vtl 104 error.
        /// </summary>
        private static DiagnosticDefinition<INamedType> vtl104Error = new(
            "VTL104",
            Severity.Error,
            "This class has already been marked as not requiring logging. Remove the [InjectControlledLogging] Aspect");

        /// <summary>
        /// (Immutable) The logger.
        /// </summary>
        [IntroduceDependency]
        private readonly ILogger logger;

        /// <summary>
        /// (Immutable) The logging apect.
        /// </summary>
        [IntroduceDependency]
        private readonly ILoggingAspect loggingAspect;

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
            //if(builder.Target.Attributes.OfAttributeType(typeof(InjectControlledLoggingAttribute)).Any())
            //{

            if(builder.Target.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any())
            {
                builder.Diagnostics.Report(vtl104Error.WithArguments(builder.Target));
                builder.Diagnostics.Suggest(
                    CodeFixFactory.RemoveAttributes(
                        builder.Target,
                        typeof(InjectControlledLoggingAttribute),
                        "Remove Aspect | InjectBasicLogging"));
                builder.SkipAspect();
            }

            if(builder.Target.Methods.Any(m => m.Enhancements().HasAspect<LogAttribute>()) ||
                builder.Target.Methods.Any(m => m.Enhancements().HasAspect<LogAndTimeAttribute>()))
            {
                builder.Diagnostics.Report(vtl102Error.WithArguments(builder.Target));
                builder.Diagnostics.Suggest(
                    CodeFixFactory.RemoveAttributes(
                        builder.Target,
                        typeof(InjectControlledLoggingAttribute),
                        "Remove Aspect | InjectControlledLogging"));
                builder.SkipAspect();
            }

            if(builder.Target.Properties.Any(p => p.Enhancements().HasAspect<LogAttribute>()) ||
                builder.Target.Properties.Any(p => p.Enhancements().HasAspect<LogAndTimeAttribute>()))
            {
                builder.Diagnostics.Report(vtl102Error.WithArguments(builder.Target));
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
            builder.MustNotHaveAspectOfType(typeof(InjectBasicLoggingAttribute));
            builder.MustNotHaveAspectOfType(typeof(NoLogAttribute));
        }

        #endregion
    }
}
