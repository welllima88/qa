using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.Authentication.WebPages
{
    public class UacLoginPageOld : WebObject, IUacLoginPage
    {
        public string UserName
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input.loginInput[name='spUsername']"))
                    .TextBox()
                    .TypeText(value);
            }
        }

        public string UserPasswort
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input.loginInput[name='spPassword']"))
                    .TextBox().TypeText(value);
            }
        }

        public IWebElement LoginButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input[alt='Login']")); }
        }
    }
}