using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Authentication;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.TestObjects.Menu;

namespace SIX.SCS.QA.Selenium.Tests.SCSClassics.TestObjects.Common
{
    public class Scs : ILoginCheck, IApplication
    {
        private readonly HeadMenu _headMenu;

        public Scs(IWebDriver driver)
        {
            _headMenu = new HeadMenu(driver);
        }

        #region ILoginCheck Members

        public void CheckLogInSucess()
        {
            //Assert.IsTrue(_headMenu.CompanyLogo.Displayed);
            Assert.IsTrue(_headMenu.System.Displayed);
        }

        #endregion

        #region IApplication Members

        public void Logout()
        {
            // TODO: doesn't work so make it work
            //_headMenu.Logout.Click();
        }

        #endregion
    }
}