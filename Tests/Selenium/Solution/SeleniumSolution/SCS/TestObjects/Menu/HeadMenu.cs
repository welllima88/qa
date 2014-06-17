using OpenQA.Selenium;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.TestObjects.Menu
{
    public class HeadMenu : WebObject
    {
        public const string MenuPrefix = "frame[name='head']";

        public IWebElement Logout
        {
            get
            {
                WebDriver.SwitchTo().Frame("head");
                return
                    WebDriver.FindElement(
                        By.CssSelector(
                            "a[href$='UAFState=logout']"));
            }
        }

        public IWebElement CompanyLogo
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(
                            "a[href$='UAFState=logout']"));
            }
        }

        public IWebElement System
        {
            get
            {
                WebDriver.SwitchTo().Frame("head");
                return
                    WebDriver.FindElement(By.CssSelector("div#system"));
            }
        }
    }
}