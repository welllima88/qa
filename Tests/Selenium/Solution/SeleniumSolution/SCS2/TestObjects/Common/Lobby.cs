using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Login;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common
{
    public class Lobby : ILogout
    {
        private readonly IWebDriverAdapter _driver;
        public ApplicationInfo ApplicationInfo;
        public Footer Footer;
        public LobbyMenu Menu;
        public MetaNavBar MetaNavBar;
        public NavigationBar NavigationBar;
        public QuickSearch QuickSearch;
        public RecentElements RecentElements;
        public RecentMassmutations RecentMassmutations;

        public Lobby(IWebDriverAdapter driver)
        {
            _driver = driver;
            Menu = new LobbyMenu(_driver);
            RecentElements = new RecentElements(_driver);
            RecentMassmutations = new RecentMassmutations(_driver);
            NavigationBar = new NavigationBar(_driver);
            Footer = new Footer(_driver);
            MetaNavBar = new MetaNavBar(_driver);
            ApplicationInfo = new ApplicationInfo(_driver);
            QuickSearch = new QuickSearch(_driver);
        }

        public IWebElement CompanyLogo
        {
            get { return _driver.FindElement(By.CssSelector("html>body>form>img.companyLogo")); }
        }

        public IWebElement Headline
        {
            get { return _driver.FindElement(By.CssSelector("td#content h1")); }
        }

        #region ILogout Members

        public void Logout()
        {
            MetaNavBar.Logout.Click();
        }

        #endregion
    }
}