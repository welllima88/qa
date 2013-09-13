using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSClassics.Tests.Selenium.TestObjects.Menu
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