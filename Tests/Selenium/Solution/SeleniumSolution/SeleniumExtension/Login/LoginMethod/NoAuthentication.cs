namespace SIX.SCS.QA.Selenium.Extension.Login.LoginMethod
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