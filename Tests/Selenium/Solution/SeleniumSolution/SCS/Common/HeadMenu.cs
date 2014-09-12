using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Old.Common
{
    public class HeadMenu : HeadObject
    {
        public IWebElementAdapter Logout
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href$='?Mode=Login&UAFState=logout']")); }
        }

        public static IWebElementAdapter CompanyLogo
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input[value='suchen']")); }
        }

        public static IWebElementAdapter System
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("div#system")); }
        }
    }
}