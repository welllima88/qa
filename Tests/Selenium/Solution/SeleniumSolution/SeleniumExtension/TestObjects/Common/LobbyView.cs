using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Authentication;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common
{
    public class LobbyView : WebObject, IApplication
    {
        public readonly ApplicationInfo ApplicationInfo;
        public readonly Footer Footer;
        public readonly LobbyNews LobbyNews;
        public readonly LobbyMenu Menu;
        public readonly MetaNavBar MetaNavBar;
        public readonly NavigationBar NavigationBar;
        public readonly ProcessTickets ProcessTickets;
        public readonly QuickSearch QuickSearch;
        public readonly RecentMassmutations RecentMassmutations;
        public readonly RecentElements RecentElements;

        public LobbyView()
        {
            Menu = new LobbyMenu();
            RecentElements=new RecentElements();
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
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.Lobby_CompanyLogo)); }
        }

        public IWebElement Headline
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.Lobby_Headline)); }
        }

        public void Logout()
        {
            MetaNavBar.Logout.Click();
        }
    }
}