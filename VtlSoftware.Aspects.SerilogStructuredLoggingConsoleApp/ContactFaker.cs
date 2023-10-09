using Bogus;
using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.SerilogStructuredLoggingConsoleApp
{
    [NoLog]
    public class ContactFaker : Faker<Contact>
    {
        #region Constructors

        public ContactFaker()
        {
            var id = 1;
            UseSeed(1958)
                .RuleFor(c => c.Id, _ => id++)
                .RuleFor(c => c.FirstName, f => f.Name.FirstName())
                .RuleFor(c => c.LastName, f => f.Name.LastName());
        }

        #endregion
    }
}
