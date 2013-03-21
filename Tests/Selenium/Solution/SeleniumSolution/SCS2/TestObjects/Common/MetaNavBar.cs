using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common
{
    public class MetaNavBar : WebObject
    {
        public MetaNavBar(IWebDriverAdapter driver) : base(driver)
        {
        }

        public IWebElement Logout
        {
            get { return Driver.FindElement(By.CssSelector(Common.MetaNavBar_Logout)); }
        }

        public IWebElement User
        {
            get { return Driver.FindElement(By.CssSelector(Common.MetaNavBar_User)); }
        }

        public IWebElement Languages
        {
            get { return Driver.FindElement(By.CssSelector(Common.MetaNavBar_Languages)); }
        }

        public IWebElement Language(string language)
        {
            return Driver.FindElement(By.XPath("//div[@class='popup']/a[text()='" + language + "']"));
        }
    }
}