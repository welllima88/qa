using System;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.Authentication;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common
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

        public void LogOff()
        {
            try
            {
                TestDirector.Navigate();
                MetaNavBar.LogOff.Click();
            }
            catch (NoSuchElementException)
            {
                Console.Error.WriteLine("Closing browser without logoff, because logout-element not found..");
            }
        }
    }
}