using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Six.Saferpay.QA.Selenium.Views.Support
{
    public class NewRequest
    {
        [FindsBy(How = How.CssSelector, Using = "tr td textarea")]
        public IWebElement Description;

        [FindsBy(How = How.CssSelector, Using = "td#content h1")]
        public IWebElement Email;

        [FindsBy(How = How.CssSelector, Using = "li#text_logout>a")]
        public IWebElement OperatingSystem;

        [FindsBy(How = How.CssSelector, Using = "html>body>img.companyLogo")]
        public IWebElement ProgrammingLanguage;

        [FindsBy(How = How.CssSelector, Using = "input.button[type='submit']")]
        public IWebElement Save;

        [FindsBy(How = How.CssSelector, Using = "html>body>img.companyLogo")]
        public IWebElement WebServer;
    }
}