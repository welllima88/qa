using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Authentication;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.TestObjects.Menu;

namespace SIX.SCS.QA.Selenium.Tests.SCSClassics.TestObjects.Common
{
    public class Scs : IApplication
    {
        private readonly HeadMenu _headMenu;

        public Scs(IWebDriver driver)
        {
            _headMenu = new HeadMenu(driver);
        }

        public void Logout()
        {
            // TODO: doesn't work so make it work
            TestLauncher.TestDirector.WebDriver.SwitchTo().Frame("head");
            _headMenu.Logout.Click();
        }
    }
}