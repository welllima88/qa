using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Six.QA.Selenium.Extension.Authentication;
using Six.QA.Selenium.Extension.WebDriver;

namespace Six.Saferpay.QA.Selenium.Views.Common
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
                LogOffLink.Click();
            }
            catch (NoSuchElementException)
            {
                Console.Error.WriteLine("Closing browser without logoff, because logout-element not found..");
            }
        }
    }
}