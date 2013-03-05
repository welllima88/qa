using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Login;
using SIX.SCS.QA.Selenium.Extension.TestObjects;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common
{
    public class Lobby : WebObject, ILogout
    {
        public ApplicationInfo ApplicationInfo;
        public Footer Footer;
        public LobbyMenu Menu;
        public MetaNavBar MetaNavBar;
        public NavigationBar NavigationBar;
        public QuickSearch QuickSearch;
        public RecentElements RecentElements;
        public RecentMassmutations RecentMassmutations;

        public Lobby(IWebDriverAdapter driver) : base(driver)
        {
            Menu = new LobbyMenu(Driver);
            RecentElements = new RecentElements(Driver);
            RecentMassmutations = new RecentMassmutations(Driver);
            NavigationBar = new NavigationBar(Driver);
            Footer = new Footer(Driver);
            MetaNavBar = new MetaNavBar(Driver);
            ApplicationInfo = new ApplicationInfo(Driver);
            QuickSearch = new QuickSearch(Driver);
        }

        public IWebElement CompanyLogo
        {
            get { return Driver.FindElement(By.CssSelector("html>body>form>img.companyLogo")); }
        }

        public IWebElement Headline
        {
            get { return Driver.FindElement(By.CssSelector("td#content h1")); }
        }

        #region ILogout Members

        public void Logout()
        {
            MetaNavBar.Logout.Click();
        }

        #endregion
    }
}