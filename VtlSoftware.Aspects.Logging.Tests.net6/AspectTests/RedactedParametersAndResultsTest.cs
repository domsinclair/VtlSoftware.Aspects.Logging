using VtlSoftware.Aspects.Logging;

namespace VtlSoftware.Aspects.Logging.Tests.net6.RedactedParametersAndResults
{
    public class RedactedParametersAndResultsTest
    {
        #region Constructors

        public RedactedParametersAndResultsTest()
        {
        }

        #endregion

        #region Public Methods
        [Log]
        [return: Redact]
        public string ValidateCardNumber(string userName, [Redact] string cardNumber)
        {
            cardNumber.Trim();

            return cardNumber;
        }

        #endregion
    }
}
