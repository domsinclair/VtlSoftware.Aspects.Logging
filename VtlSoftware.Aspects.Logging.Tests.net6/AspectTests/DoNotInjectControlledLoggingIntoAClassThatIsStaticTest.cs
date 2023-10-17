using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.Logging.Tests.net6.DoNotInjectControlledLoggingIntoAClassThatIsStatic
{
    [InjectControlledLogging]
    internal static class DoNotInjectControlledLoggingIntoAClassThatIsStaticTest
    {
    }
}
