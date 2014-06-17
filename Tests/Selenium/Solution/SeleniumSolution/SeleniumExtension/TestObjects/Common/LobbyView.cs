using System;
using OpenQA.Selenium;
using Six.Scs.Tests.Selenium.Extension.Authentication;
using Six.Scs.Tests.Selenium.Extension.WebDriver;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Common
{
    public class LobbyView : WebObject, IApplication
    {
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
                TestDirector.Navigate();
                MetaNavBar.Logout.Click();
            }
            catch (NoSuchElementException)
            {
                Console.Error.WriteLine("Closing browser without logoff, because logout-element not found..");
            }
        }
    }
}