using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Six.Saferpay.QA.Selenium.Views.Common
{
    public class NavigationBar
    {
        [FindsBy(How = How.CssSelector, Using = "li#topic_home a")] public IWebElement MySaferpay;

        [FindsBy(How = How.CssSelector, Using = "li#topic_support a")] public IWebElement OnlineSupport;
    }
}