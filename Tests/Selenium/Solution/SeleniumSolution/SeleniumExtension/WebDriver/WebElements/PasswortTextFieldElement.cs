using OpenQA.Selenium;

namespace Six.QA.Selenium.Extension.WebDriver.WebElements
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