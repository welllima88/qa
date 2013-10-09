using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common
{
    public class MetaNavBar : WebObject
    {
        public IWebElement Logout
        {
            get { return WebDriver.FindElement(By.CssSelector(Common.MetaNavBar_Logout)); }
        }

        public IWebElement User
        {
            get { return WebDriver.FindElement(By.CssSelector(Common.MetaNavBar_User)); }
        }

        public IWebElement Languages
        {
            get { return WebDriver.FindElement(By.CssSelector(Common.MetaNavBar_Languages)); }
        }

        public IWebElement Language(string language)
        {
            return WebDriver.FindElement(By.XPath("//div[@class='popup']/a[text()='" + language + "']"));
        }
    }
}