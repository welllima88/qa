using System;
using OpenQA.Selenium;
using Six.Test.Selenium.Authentication;
using Six.Test.Selenium.WebDriver;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Common
{
    public class Lobby : WebObject, IApplication
    {
        public static IWebElement CompanyLogo
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("html>body>img.companyLogo")); }
        }

        public static IWebElement Headline
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