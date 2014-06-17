using OpenQA.Selenium;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Common
{
    public class MetaNavBar : WebObject
    {
        public static IWebElement Logout
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.MetaNavBar_Logout)); }
        }

        public static IWebElement User
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector("td#metaNavBar a#ctl00_hplSimpleUserInfo[href*='/User/Index?UserName=']"));
            }
        }

        public static IWebElement Languages
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.MetaNavBar_Languages)); }
        }

        public static IWebElement Language(string language)
        {
            return WebDriver.FindElement(By.XPath("//div[@class='popup']/a[text()='" + language + "']"));
        }
    }
}