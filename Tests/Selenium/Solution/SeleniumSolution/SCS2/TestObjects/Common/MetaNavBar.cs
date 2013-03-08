using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common
{
    public class MetaNavBar : WebObject
    {
        public MetaNavBar(IWebDriverAdapter driver) : base(driver)
        {
            Prefix = "td#metaNavBar ";
        }

        public IWebElement Logout
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + "a#ctl00_hplLogout[href*='/Logout.aspx']")); }
        }

        public IWebElement User
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(Prefix +
                                       "a#ctl00_hplSimpleUserInfo[href*='/User/UserEdit.aspx?PageMode=view&UserName=']"));
            }
        }

        public IWebElement Languages
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + "a#ctl00_hplLanguages.menu")); }
        }

        public IWebElement Language(string language)
        {
            return Driver.FindElement(By.XPath("//div[@class='popup']/a[text()='" + language + "']"));
        }
    }
}