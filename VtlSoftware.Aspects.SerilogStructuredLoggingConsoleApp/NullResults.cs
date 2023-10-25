using VtlSoftware.Aspects.Logging;

namespace VtlSoftware.Aspects.SerilogStructuredLoggingConsoleApp
{
    internal class NullResults
    {
        #region Public Methods

        [Log]
        public string? Failure(string? failed)
        {
            if(failed == null)
            {
                throw new ArgumentNullException("Failed should not be null");
            }
            return failed;
        }

        [Log]
        public DateTime? Nulldays(string? dayofWeek)
        {
            DateTime? date = null;
            if(dayofWeek != null)
                switch(dayofWeek.ToLowerInvariant())
                {
                    case "mon":
                        date = DateTime.Now.AddDays(1);
                        break;
                    case "tue":
                        date = DateTime.Now.AddDays(2);
                        break;
                    case "wed":
                        date = DateTime.Now.AddDays(3);
                        break;
                    case "thu":
                        date = DateTime.Now.AddDays(4);
                        break;
                    case "fri":
                        date = DateTime.Now.AddDays(5);
                        break;
                    case "sat":
                        date = DateTime.Now.AddDays(6);
                        break;
                    case "sun":
                        date = DateTime.Now.AddDays(7);
                        break;
                }
            return date;
        }

        #endregion
    }
}

