using System;
using OpenQA.Selenium;
using Six.QA.Selenium.Extension.Authentication;
using Six.QA.Selenium.Extension.WebDriver;
using Six.QA.Selenium.Extension.WebDriver.WebElements;
using Six.Saferpay.QA.Selenium.Views.Common;

namespace Six.Saferpay.QA.Selenium
{
    public class Lobby : WebObject, IApplication
    {
        public static IWebElementAdapter CompanyLogo
        {
            get { return WebDriver.FindAdaptedElement(By.Id("html>body>img.companyLogo")); }
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