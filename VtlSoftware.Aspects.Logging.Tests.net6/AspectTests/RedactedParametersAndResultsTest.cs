using VtlSoftware.Aspects.Logging.Net6;

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
        [LogMethod]
        [return: Redact]
        public string ValidateCardNumber(string userName, [Redact] string cardNumber)
        {
            cardNumber.Trim();

            return cardNumber;
        }

        #endregion
    }
}
