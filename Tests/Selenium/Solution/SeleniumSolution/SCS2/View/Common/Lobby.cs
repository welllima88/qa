using System;
using OpenQA.Selenium;
using Six.Test.Selenium.Authentication;
using Six.Test.Selenium.WebDriver;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Common
{
    public class Lobby : WebObject, IApplication
    {
        public static IWebElementAdapter CompanyLogo
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("html>body>img.companyLogo")); }
        }

        public static IWebElementAdapter Headline
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content h1")); }
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