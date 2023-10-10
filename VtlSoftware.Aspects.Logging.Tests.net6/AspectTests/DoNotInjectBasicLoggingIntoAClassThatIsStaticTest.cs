using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.Logging.Tests.net6.DoNotInjectBasicLoggingIntoAClassThatIsStatic
{
    [InjectBasicLogging]
    internal static class DoNotInjectBasicLoggingIntoAClassThatIsStaticTest
    {
    }
}
