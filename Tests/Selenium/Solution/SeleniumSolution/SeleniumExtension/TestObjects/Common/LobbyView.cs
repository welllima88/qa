using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Authentication;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common
{
    public class LobbyView : WebObject, IApplication
    {
        public static ApplicationInfo ApplicationInfo;
        public static Footer Footer;
        public static LobbyNews LobbyNews;
        public static LobbyMenu Menu;
        public static MetaNavBar MetaNavBar;
        public static NavigationBar NavigationBar;
        public static ProcessTickets ProcessTickets;
        public static RecentElements RecentElements;
        public static RecentMassmutations RecentMassmutations;
        public static QuickSearch QuickSearch;

        public static IWebElement CompanyLogo
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.Lobby_CompanyLogo)); }
        }

        public static IWebElement Headline
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.Lobby_Headline)); }
        }

        public void Logout()
        {
            try
            {
                MetaNavBar.Logout.Click();
            }
            catch (NoSuchElementException)
            {
                Console.Error.WriteLine("Closing browser without logoff, because logout-element not found..");
            }
        }
    }
}