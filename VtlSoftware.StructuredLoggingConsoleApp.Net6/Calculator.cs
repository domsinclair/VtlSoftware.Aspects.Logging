using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.StructuredLoggingConsoleApp.Net6
{
    internal class Calculator
    {
        #region Constructors

        public Calculator()
        {
        }

        #endregion

        #region Public Methods
        [Log]
        public double Add(double a, double b) { return a + b; }

        [Log]
        public double Divide(double a, double b) { return a / b; }

        [Log]
        public double Multiply(double a, double b) { return a * b; }

        [Log]
        public void Run(double a, double b)
        {
            Add(a, b);
            Subtract(a, b);
            Multiply(a, b);
            Divide(a, b);
        }

        [Log]
        public double Subtract(double a, double b) { return a - b; }

        #endregion
    }
}
