namespace VtlSoftware.StructuredLoggingConsoleApp.Net6
{
    public class Contact
    {
        #region Public Properties

        public string FirstName { get; set; } = string.Empty;

        public string FullName => $"{FirstName} {LastName}";

        public int Id { get; set; }

        public string LastName { get; set; } = string.Empty;

        #endregion
    }
}
