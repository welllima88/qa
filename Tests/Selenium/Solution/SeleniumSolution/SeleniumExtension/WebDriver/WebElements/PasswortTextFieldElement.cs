using OpenQA.Selenium;

namespace Six.Test.Selenium.WebDriver.WebElements
{
    public class PasswortTextFieldElement : TextFieldElement
    {
        public PasswortTextFieldElement(OpenQA.Selenium.IWebElement webElement) : base(webElement)
        {
        }

        protected override string Type()
        {
            return "password";
        }
    }
}