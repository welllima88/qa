using OpenQA.Selenium.Support.PageObjects;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Saferpay.QA.Selenium.Common
{
    public class MetaNavBar
    {
        [FindsBy(How = How.CssSelector, Using = "li#text_logout a")] public static IWebElementAdapter LogOff;
    }
}