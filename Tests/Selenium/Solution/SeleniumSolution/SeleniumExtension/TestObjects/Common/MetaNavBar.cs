using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common
{
    public class MetaNavBar : WebObject
    {
        public static IWebElement Logout
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.MetaNavBar_Logout)); }
        }

        public static IWebElement User
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.MetaNavBar_User)); }
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