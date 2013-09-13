using OpenQA.Selenium;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Authentication;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common
{
    public class LobbyView : WebObject, IApplication
    {
        public ApplicationInfo ApplicationInfo;
        public Footer Footer;
        public LobbyNews LobbyNews;
        public LobbyMenu Menu;
        public MetaNavBar MetaNavBar;
        public NavigationBar NavigationBar;
        public ProcessTickets ProcessTickets;
        public QuickSearch QuickSearch;
        public RecentElements RecentElements;
        public RecentMassmutations RecentMassmutations;

        #region IApplication Members

        public void Logout()
        {
            MetaNavBar.Logout.Click();
        }

        #endregion

        public LobbyView()
        {
            Menu = new LobbyMenu();
            RecentElements = new RecentElements();
            RecentMassmutations = new RecentMassmutations();
            NavigationBar = new NavigationBar();
            Footer = new Footer();
            MetaNavBar = new MetaNavBar();
            ApplicationInfo = new ApplicationInfo();
            LobbyNews = new LobbyNews();
            QuickSearch = new QuickSearch();
            ProcessTickets = new ProcessTickets();
        }

        public IWebElement CompanyLogo
        {
            get { return WebDriver.FindElement(By.CssSelector(Common.Lobby_CompanyLogo)); }
        }

        public IWebElement Headline
        {
            get { return WebDriver.FindElement(By.CssSelector(Common.Lobby_Headline)); }
        }
    }
}