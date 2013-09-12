using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.Authentication.WebPages
{
    public class UacLoginPageOld : WebObject
    {
        public string UserName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input.loginInput[name='spUsername']")).TypeText(value); }
        }

        public string UserPasswort
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input.loginInput[name='spPassword']"))
                         .TypeText(value);
            }
        }

        public IWebElement LoginButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input.loginInput[alt='Login']")); }
        }
    }
}