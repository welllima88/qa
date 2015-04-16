using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Six.QA.Selenium.Extension.WebDriver;

namespace Six.Saferpay.QA.Selenium.Pages.Common
{
    public class NavigationBar
    {
        [FindsBy(How = How.CssSelector, Using = "li#topic_home a")] public IWebElement MySaferpay;

        [FindsBy(How = How.CssSelector, Using = "li#topic_support a")] public IWebElement OnlineSupport;

        public NavigationBar()
        {
            PageFactory.InitElements(TestDirector.WebDriver, this);
        }
    }
}