using Metalama.Framework.Aspects;
using Metalama.Framework.Code;
using Metalama.Framework.Fabrics;

namespace VtlSoftware.Aspects.Logging.Net6
{
    /// <summary>
    /// A collection of fabric extensions.
    /// </summary>
    ///
    /// <remarks></remarks>

    [CompileTime]
    public static class FabricExtensions
    {
        #region Public Methods
        /// <summary>
        /// An IProjectAmender extension method that adds the functionality to add basic logging to all classes.
        /// </summary>
        ///
        /// <remarks>
        /// This fabric extension adds (via Dependency Injection) the Microsoft.Extensions.Logging ILogger interface to
        /// all of those classes in a project that are not static or have neither the [InjectControlledLogging] Aspect
        /// On the class or either of [Log] or [LogAndTime] Aspects on methods or properties in the class.
        /// </remarks>
        ///
        /// <param name="amender">The amender to act on.</param>

        public static void AddBasicLoggingToAllClasses(this IProjectAmender amender)
        {
            amender.Outbound
                .SelectMany(compilation => compilation.AllTypes)
               .Where(
                   type => !type.IsStatic &&
                       !type.Attributes.OfAttributeType(typeof(InjectControlledLoggingAttribute)).Any() &&
                       !type.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any())
                .AddAspectIfEligible<InjectBasicLoggingAttribute>();
        }

        /// <summary>
        /// An IProjectAmender extension method that adds the functionality to add basic logging to all classes.
        /// </summary>
        ///
        /// <remarks>
        /// This fabric extension adds (via Dependency Injection) the Microsoft.Extensions.Logging ILogger interface 
        /// and the VtlSoftware ILoggingAspect interface to all of those classes in a project that are not static or 
        /// have neither the [InjectControlledLogging] Aspect On the class or either of [Log] or [LogAndTime] Aspects on
        /// methods or properties in the class.
        /// </remarks>
        ///
        /// <param name="amender">The amender to act on.</param>

        public static void AddControlledLoggingToAllClasses(this IProjectAmender amender)
        {
            amender.Outbound
                .SelectMany(compilation => compilation.AllTypes)
                .Where(
                    type => !type.IsStatic &&
                        !type.Attributes.OfAttributeType(typeof(InjectBasicLoggingAttribute)).Any() &&
                        !type.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any())
                .AddAspectIfEligible<InjectControlledLoggingAttribute>();
        }

        /// <summary>
        /// An IProjectAmender extension method that logs all methods, by applying the [LogMethod] attribute.
        /// </summary>
        ///
        /// <remarks>
        /// Static classes will be ignored as will those marked with the [NoLog] attribute.
        /// </remarks>
        ///
        /// <param name="amender">The amender to act on.</param>

        public static void LogAllMethods(this IProjectAmender amender)
        {
            amender.Outbound
            .SelectMany(compilation => compilation.AllTypes)
            .Where(type => !type.IsStatic || type.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any())
            .SelectMany(type => type.Methods)
            .Where(method => method.Name != "ToString")
            .AddAspectIfEligible<LogAttribute>();
        }

        /// <summary>
        /// An IProjectAmender extension method that logs all properties.
        /// </summary>
        ///
        /// <remarks>Static classes will be ignored.</remarks>
        ///
        /// <param name="amender">The amender to act on.</param>

        public static void LogAllProperties(this IProjectAmender amender)
        {
            amender.Outbound
            .SelectMany(compilation => compilation.AllTypes)
            .Where(type => !type.IsStatic)
            .SelectMany(type => type.Properties)
             .AddAspectIfEligible<LogAttribute>();
        }

        /// <summary>
        /// An IProjectAmender extension method that logs all public and private methods, by applying the [LogMethod]
        /// attribute.
        /// </summary>
        ///
        /// <remarks>
        /// Static classes will be ignored, as will those marked with the [NoLog] attribute.
        /// </remarks>
        ///
        /// <param name="amender">The amender to act on.</param>

        public static void LogAllPublicAndPrivateMethods(this IProjectAmender amender)
        {
            amender.Outbound
            .SelectMany(compilation => compilation.AllTypes)
            .Where(
                type => type.Accessibility is Accessibility.Public or Accessibility.Internal &&
                    !type.IsStatic ||
                    type.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any())
            .SelectMany(type => type.Methods)
            .Where(
                method => method.Accessibility is Accessibility.Public or Accessibility.Private &&
                    method.Name != "ToString")
            .AddAspectIfEligible<LogAttribute>();
        }

        /// <summary>
        /// An IProjectAmender extension method that logs all public methods, by applying the [LogMethod] attribute.
        /// </summary>
        ///
        /// <remarks>
        /// Static classes will be ignored, as will those marked with the [NoLog] attribute.
        /// </remarks>
        ///
        /// <param name="amender">The amender to act on.</param>

        public static void LogAllPublicMethods(this IProjectAmender amender)
        {
            amender.Outbound
            .SelectMany(compilation => compilation.AllTypes)
            .Where(
                type => type.Accessibility is Accessibility.Public or Accessibility.Internal &&
                    !type.IsStatic ||
                    type.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any())
            .SelectMany(type => type.Methods)
            .Where(method => method.Accessibility is Accessibility.Public && method.Name != "ToString")
            .AddAspectIfEligible<LogAttribute>();
        }

        /// <summary>
        /// An IProjectAmender extension method that logs and times all methods, by applyining the [TimedLogMethod]
        /// attribute.
        /// </summary>
        ///
        /// <remarks>
        /// Static classes will be ignored, as will those marked with the [NoLog] attribute.
        /// </remarks>
        ///
        /// <param name="amender">The amender to act on.</param>

        public static void LogAndTimeAllMethods(this IProjectAmender amender)
        {
            amender.Outbound
            .SelectMany(compilation => compilation.AllTypes)
            .Where(type => !type.IsStatic || type.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any())
            .SelectMany(type => type.Methods)
            .Where(method => method.Name != "ToString")
            .AddAspectIfEligible<LogAndTimeAttribute>();
        }

        /// <summary>
        /// An IProjectAmender extension method that logs and time all public and private methods, by applying the
        /// [TimedLogMethod] attribute.
        /// </summary>
        ///
        /// <remarks>
        /// Static classes will be ignored, as will those marked with the  [NoLog] attribute.
        /// </remarks>
        ///
        /// <param name="amender">The amender to act on.</param>

        public static void LogAndTimeAllPublicAndPrivateMethods(this IProjectAmender amender)
        {
            amender.Outbound
            .SelectMany(compilation => compilation.AllTypes)
            .Where(
                type => type.Accessibility is Accessibility.Public or Accessibility.Internal &&
                    !type.IsStatic ||
                    type.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any())
            .SelectMany(type => type.Methods)
            .Where(
                method => method.Accessibility is Accessibility.Public or Accessibility.Private &&
                    method.Name != "ToString")
            .AddAspectIfEligible<LogAndTimeAttribute>();
        }

        /// <summary>
        /// An IProjectAmender extension method that logs and times all public methods, by applying the [TimedLogMethod]
        /// attribute.
        /// </summary>
        ///
        /// <remarks>
        /// Static classes will be ignored, as will those marked with the [NoLog] attribute.
        /// </remarks>
        ///
        /// <param name="amender">The amender to act on.</param>

        public static void LogAndTimeAllPublicMethods(this IProjectAmender amender)
        {
            amender.Outbound
           .SelectMany(compilation => compilation.AllTypes)
           .Where(
               type => type.Accessibility is Accessibility.Public or Accessibility.Internal &&
                   !type.IsStatic ||
                   type.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any())
           .SelectMany(type => type.Methods)
           .Where(method => method.Accessibility is Accessibility.Public && method.Name != "ToString")
           .AddAspectIfEligible<LogAndTimeAttribute>();
        }

        /// <summary>
        /// An IProjectAmender extension method that logs an everything, by applying the [LogMethod] attribute to
        /// methods and the  [LogProperty] attribute to properties.
        /// </summary>
        ///
        /// <remarks>Static classes will be ignored.</remarks>
        ///
        /// <param name="amender">The amender to act on.</param>

        public static void LogEverything(this IProjectAmender amender)
        {
            var types = amender.Outbound
            .SelectMany(compilation => compilation.AllTypes)
            .Where(type => !type.IsStatic);
            types.SelectMany(type => type.Methods)
                .Where(method => method.Name != "ToString")
                .AddAspectIfEligible<LogAttribute>();
            types.SelectMany(type => type.Properties)
                .AddAspectIfEligible<LogAttribute>();
        }

        /// <summary>
        /// An IProjectAmender extension method that Times every method and logs every property.
        /// </summary>
        ///
        /// <remarks>Static classes will be ignored.</remarks>
        ///
        /// <param name="amender">The amender to act on.</param>

        public static void TimeEveryMethodAndLogEveryProperty(this IProjectAmender amender)
        {
            var types = amender.Outbound
            .SelectMany(compilation => compilation.AllTypes)
            .Where(type => !type.IsStatic);
            types.SelectMany(type => type.Methods)
                .Where(method => method.Name != "ToString")
                .AddAspectIfEligible<LogAndTimeAttribute>();
            types.SelectMany(type => type.Properties)
                .AddAspectIfEligible<LogAndTimeAttribute>();
        }

        #endregion
    }
}
