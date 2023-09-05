using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.ConsoleApp.Net6
{
    [NoLog]
    internal class MathematicalFunctions
    {
        #region Constructors

        public MathematicalFunctions()
        {
        }

        #endregion

        #region Public Methods
        [LogMethod]
        public double Add(double x, double y) { return x + y; }

        #endregion
    }
}
