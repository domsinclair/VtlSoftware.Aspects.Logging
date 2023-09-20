using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.ConsoleApp.Net6
{
    internal partial class General
    {
        #region Constructors
        public General()
        {
        }

        #endregion

        #region Public Properties
        [Log]
        public string MyString { get; set; }

        #endregion
    }
}
