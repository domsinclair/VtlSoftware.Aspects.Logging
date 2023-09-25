using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.StructuredLoggingConsoleApp.Net6
{
    internal class DataFun
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
        [LogAndTime]
        public Dictionary<int, string> GetDictionary()
        {
            CreateDictionaryOfContacts();
            return contactsDictionary;
        }

        [Log]
        public List<string> GetSelectedContacts()
        {
            List<string> strings = new List<string>();
            strings.Add(contactsDictionary[5]);
            strings.Add(contactsDictionary[15]);
            strings.Add(contactsDictionary[25]);
            strings.Add(contactsDictionary[35]);
            strings.Add(contactsDictionary[45]);

            return strings;
        }

        #endregion
    }
}
