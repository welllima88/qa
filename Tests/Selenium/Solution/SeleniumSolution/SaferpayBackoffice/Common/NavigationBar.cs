using OpenQA.Selenium.Support.PageObjects;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Saferpay.QA.Selenium.Common
{
    public class NavigationBar
    {
        [FindsBy(How = How.CssSelector, Using = "li#topic_home a")] public static IWebElementAdapter MySaferpay;

        [FindsBy(How = How.CssSelector, Using = "li#topic_support a")] public static IWebElementAdapter OnlineSupport;
    }
}