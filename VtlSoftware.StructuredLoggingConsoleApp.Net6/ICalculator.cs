namespace VtlSoftware.StructuredLoggingConsoleApp.Net6
{
    public interface ICalculator
    {
        #region Public Methods

        double Add(double a, double b);

        int Divide(int a, int b);

        double Multiply(double a, double b);

        void Run();

        double Subtract(double a, double b);

        #endregion
    }
}
