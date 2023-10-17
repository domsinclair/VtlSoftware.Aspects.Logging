using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.SerilogStructuredLoggingConsoleApp
{
    internal partial class DataFun
    {
        #region Fields
        Dictionary<int, string> contactsDictionary = new();

        #endregion

        #region Private Methods
        private void CreateDictionaryOfContacts()
        {
            var contacts = new ContactFaker().Generate(100);
            foreach(Contact con in contacts)
            {
                contactsDictionary.Add(con.Id, con.FullName);
            }
        }

        #endregion

        #region Public Methods
        [Log]
        [return: Redact]
        public Dictionary<int, string> GetDictionary()
        {
            CreateDictionaryOfContacts();
            return contactsDictionary;
        }

        [Log]
        public List<string> GetSelectedContacts()
        {
            List<string> strings = new()
            {
                contactsDictionary[5],
                contactsDictionary[15],
                contactsDictionary[25],
                contactsDictionary[35],
                contactsDictionary[45]
            };
            return strings;
        }

        #endregion
    }
}
