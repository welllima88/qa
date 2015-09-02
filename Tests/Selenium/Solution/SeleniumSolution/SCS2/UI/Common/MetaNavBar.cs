using System.Collections.Generic;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Common
{
    public class MetaNavBar : WebObject
    {
        public static IWebElement LogOff
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#metaNavBar a#ctl00_hplLogout[href$='/Account/Logout/']"));
            }
        }

        public static IWebElement User
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#metaNavBar a#ctl00_hplSimpleUserInfo[href*='/User/Preferences?UserName=']"));
            }
        }

        public static IWebElement Languages
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#metaNavBar a#ctl00_hplLanguages.menu")); }
        }

        public static string ActualLanguage
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#metaNavBar a.menu#ctl00_hplLanguages")).Text; }
        }

        public static IWebElement CompanyLogo
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("html body#body img.companyLogo[alt='six logo']"));
            }
        }

        public static IEnumerable<IWebElement> LanguageItems
        {
            get { return WebDriver.FindAdaptedElements(By.CssSelector("body>div.popup>a")); }
        }
    }
}