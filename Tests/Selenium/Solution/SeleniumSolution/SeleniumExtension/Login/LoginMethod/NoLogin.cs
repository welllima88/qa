namespace SIX.SCS.QA.Selenium.Extension.Login.LoginMethod
{
    public class NoLogin : ILogin, ILogoutCheck
    {
        #region ILogin Members

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