using System.Collections.Generic;
using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.View.Common
{
    public class MetaNavBar : WebObject
    {
        public static IWebElementAdapter LogOff
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("td#metaNavBar a#ctl00_hplLogout[href$='/Account/Logout/']"));
            }
        }

        public static IWebElementAdapter User
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#metaNavBar a#ctl00_hplSimpleUserInfo[href*='/User/Preferences?UserName=']"));
            }
        }

        public static IWebElementAdapter Languages
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#metaNavBar a#ctl00_hplLanguages.menu")); }
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

        public static IEnumerable<IWebElementAdapter> LanguageItems
        {
            get { return WebDriver.FindAdaptedElements(By.CssSelector("body>div.popup>a")); }
        }
    }
}