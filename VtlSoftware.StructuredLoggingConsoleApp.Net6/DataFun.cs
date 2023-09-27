using Microsoft.Extensions.Logging;
using VtlSoftware.Aspects.Common.Net6;
using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.StructuredLoggingConsoleApp.Net6
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
#if DEBUG
            //this illustrates how additional log messages can be created in addition to those basic messages
            //added by the [Log] aspect.
            //
            //In order to do this the class itself must be declared as partial, thuss providing access to the ILogger
            //added by the aspect.
            var contactName = strings[0];
            logger.Log(LogLevel.Debug, $"This is a debug only message showing the fifth entry in the dictionary which is: {contactName}");
#endif
            strings.Add(contactsDictionary[15]);
            strings.Add(contactsDictionary[25]);
            strings.Add(contactsDictionary[35]);
            strings.Add(contactsDictionary[45]);

            return strings;
        }

#endregion
    }
}
