using Metalama.Framework.Fabrics;
using VtlSoftware.Aspects.Logging;
namespace VtlSoftware.Aspects.Logging.Tests.net6.DoNotLogAllPublicMethodsInNoLogDecoratedClass
{
    [NoLog]
    internal class DoNotLogAllPublicMethodsInNoLogDecoratedClass
    {
        private void DoSomethingElse()
        {
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public void DoSomething()
        {
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
    public static class Static1
    {
        public static void DoMoreStuff()
        {
        }
    }
#pragma warning disable CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
    public class SecondFabric : ProjectFabric
    {
        public override void AmendProject(IProjectAmender amender) => throw new System.NotSupportedException("Compile-time-only code cannot be called at run-time.");
    }
#pragma warning restore CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
}