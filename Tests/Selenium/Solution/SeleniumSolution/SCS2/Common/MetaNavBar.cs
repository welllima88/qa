using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common
{
    public class MetaNavBar : WebObject
    {
        public static IWebElementAdapter LogOff
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CommonRes.MetaNavBar_Logout)); }
        }

        public static IWebElementAdapter User
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#metaNavBar a#ctl00_hplSimpleUserInfo[href*='/User/Index?UserName=']"));
            }
        }

        public static IWebElementAdapter Languages
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CommonRes.MetaNavBar_Languages)); }
        }

        public static string ActualLanguage
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#metaNavBar a.menu#ctl00_hplLanguages")).Text; }
        }

        public static IWebElementAdapter CompanyLogo
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("html body#body img.companyLogo[alt='six logo']"));
            }
        }

        public static IWebElementAdapter LanguageItem(string language)
        {
            return WebDriver.FindAdaptedElement(By.XPath("//div[@class='popup']/a[text()='" + language + "']"));
        }
    }
}