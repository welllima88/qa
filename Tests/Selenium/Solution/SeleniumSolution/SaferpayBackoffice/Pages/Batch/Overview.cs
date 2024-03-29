using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Six.Saferpay.Backoffice.Test.Pages.Batch
{
    public class Overview
    {
        [FindsBy(How = How.CssSelector, Using = "html>body>img.companyLogo")]
        public IWebElement CompanyLogo;

        [FindsBy(How = How.CssSelector, Using = "td#content h1")]
        public IWebElement Headline;

        [FindsBy(How = How.CssSelector, Using = "li#text_logout>a")]
        public IWebElement LogOffLink;
    }
}