using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Six.QA.Selenium.Extension.Authentication;
using Six.QA.Selenium.Extension.WebDriver;

namespace Six.Saferpay.QA.Selenium.Pages.Common
{
    public class Lobby : IApplication
    {
        [FindsBy(How = How.CssSelector, Using = "html>body>img.companyLogo")] public IWebElement CompanyLogo;
        [FindsBy(How = How.CssSelector, Using = "td#content h1")] public IWebElement Headline;
        [FindsBy(How = How.CssSelector, Using = "li#text_logout>a")] public IWebElement LogOffLink;

        public void LogOff()
        {
            try
            {
                TestDirector.Navigate();
                // redirect is very slow and we click the logoff with lower timeout
                TestDirector.WebDriver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(2));
                LogOffLink.Click();
            }
            catch (NoSuchElementException)
            {
                Console.Error.WriteLine("Closing browser without logoff, because logout-element not found..");
            }
        }
    }
}