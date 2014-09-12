using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Old.Common
{
    public class HeadMenu : WebObject
    {
        public const string MenuPrefix = "frame[name='head']";

        public IWebElementAdapter Logout
        {
            get
            {
                WebDriver.SwitchTo().Frame("head");
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "a[href$='UAFState=logout']"));
            }
        }

        public static IWebElementAdapter CompanyLogo
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "a[href$='UAFState=logout']"));
            }
        }

        public static IWebElementAdapter System
        {
            get
            {
                WebDriver.SwitchTo().Frame("head");
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("div#system"));
            }
        }
    }
}