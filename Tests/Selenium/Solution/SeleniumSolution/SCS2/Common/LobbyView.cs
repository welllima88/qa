using System;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.Authentication;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common
{
    public class LobbyView : WebObject, IApplication
    {
        public static IWebElementAdapter CompanyLogo
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CommonRes.Lobby_CompanyLogo)); }
        }

        public static IWebElementAdapter Headline
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CommonRes.Lobby_Headline)); }
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