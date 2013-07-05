using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Authentication;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common
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

        public LobbyView(IWebDriverAdapter driver) : base(driver)
        {
            Menu = new LobbyMenu(Driver);
            RecentElements = new RecentElements(Driver);
            RecentMassmutations = new RecentMassmutations(Driver);
            NavigationBar = new NavigationBar(Driver);
            Footer = new Footer(Driver);
            MetaNavBar = new MetaNavBar(Driver);
            ApplicationInfo = new ApplicationInfo(Driver);
            LobbyNews = new LobbyNews(Driver);
            QuickSearch = new QuickSearch(Driver);
            ProcessTickets = new ProcessTickets(Driver);
        }

        public IWebElement CompanyLogo
        {
            get { return Driver.FindElement(By.CssSelector(Common.Lobby_CompanyLogo)); }
        }

        public IWebElement Headline
        {
            get { return Driver.FindElement(By.CssSelector(Common.Lobby_Headline)); }
        }
    }
}