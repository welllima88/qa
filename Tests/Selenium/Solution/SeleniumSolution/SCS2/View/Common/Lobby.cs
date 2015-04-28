using System;
using OpenQA.Selenium;
using Six.QA.Selenium.Extension.Authentication;
using Six.QA.Selenium.Extension.WebDriver;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Application.View.Common
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