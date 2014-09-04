using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.Authentication.Webpages
{
    public class UacLogOnPageOld : WebObject, IUacLogOnPage
    {
        public string UserName
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input.loginInput[name='spUsername']"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public string UserPasswort
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input.loginInput[name='spPassword']"))
                    .TextField().TypeText(value);
            }
        }

        public IWebElement LoginButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input[alt='Login']")); }
        }
    }
}