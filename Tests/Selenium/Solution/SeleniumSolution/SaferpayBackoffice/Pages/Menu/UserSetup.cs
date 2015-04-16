using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Six.Saferpay.QA.Selenium.Pages.Menu
{
    public class UserSetup
    {
        [FindsBy(How = How.CssSelector, Using = "div#menu li a[href$='/BO/ChangeEmailAddress']")]
        public IWebElement
            ChangeEmail;

        [FindsBy(How = How.CssSelector, Using = "div#menu li a[href$='/BO/ChangePassword']")]
        public IWebElement
            ChangePassword;
    }
}