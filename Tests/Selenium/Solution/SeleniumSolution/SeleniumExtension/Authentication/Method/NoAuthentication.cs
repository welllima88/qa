namespace SIX.SCS.QA.Selenium.Extension.Authentication.Method
{
    public class NoAuthentication : IAuthentication, ILogoutCheck
    {
        #region IAuthentication Members

        public void Login()
        {
        }

        #endregion

        #region ILogoutCheck Members

        public void CheckLogOutSucess()
        {
        }

        #endregion
    }
}