using OpenQA.Selenium;

namespace Six.Test.Selenium.WebDriver.WebElements
{
    public class PasswortTextFieldElement : TextFieldElement
    {
        public PasswortTextFieldElement(IWebElement webElement) : base(webElement)
        {
        }

        protected override string Type()
        {
            return "password";
        }
    }
}