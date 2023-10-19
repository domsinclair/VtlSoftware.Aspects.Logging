namespace VtlSoftware.Aspects.Logging.Tests.net6.AsyncLogVoidMethod
{
    public class AsyncLogVoidMethodTest
    {
        #region Constructors

        public AsyncLogVoidMethodTest()
        {
        }

        #endregion

        #region Public Methods
        [Log]
        public async void DoSomething()
        {
            //Do something here
        }

        #endregion
    }
}
