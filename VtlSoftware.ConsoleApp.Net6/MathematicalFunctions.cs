using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.ConsoleApp.Net6
{
    internal class MathematicalFunctions
    {
        #region Constructors

        public MathematicalFunctions()
        {
        }

        #endregion

        #region Public Methods
        [LogAndTime]
        public double Add(double x, double y) { return x + y; }

        #endregion
    }
}
