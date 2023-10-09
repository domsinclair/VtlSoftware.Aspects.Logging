
using Metalama.Extensions.DependencyInjection;
using Metalama.Framework.Advising;
using Metalama.Framework.Aspects;
using Metalama.Framework.Code;
using Metalama.Framework.Eligibility;
using Microsoft.Extensions.Logging;

#pragma warning disable CS0649, CS8618, IDE0051
namespace VtlSoftware.Aspects.Logging.Net6
{
    /// <summary>
    /// Attribute for inject controlled logging.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <seealso cref="T:Attribute"/>
    /// <seealso cref="T:IAspect{INamedType}"/>

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class InjectControlledLoggingAttribute : Attribute, IAspect<INamedType>
    {
        #region Fields
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
        /// <seealso cref="M:IEligible.BuildEligibility(IEligibilityBuilder{INamedType})"/>
        /// <seealso href="@eligibility"/>

        public void BuildEligibility(IEligibilityBuilder<INamedType> builder)
        {
            EligibilityRuleFactory.GetAdviceEligibilityRule(AdviceKind.ImplementInterface);
            builder.MustNotBeStatic();
            builder.MustNotHaveAspectOfType(typeof(InjectBasicLoggingAttribute));
        }

        #endregion
    }
}
