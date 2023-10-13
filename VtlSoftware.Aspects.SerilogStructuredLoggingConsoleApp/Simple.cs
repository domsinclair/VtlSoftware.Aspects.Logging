namespace VtlSoftware.Aspects.SerilogStructuredLoggingConsoleApp
{
    public class Simple
    {
        #region Private Methods

        private static  string ConvertToUpper(string value) { return value.ToUpper(); }

        #endregion

        #region Public Properties
        public static string? MyString { get; set; }

        #endregion
    }
}
