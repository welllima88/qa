using OpenQA.Selenium;

namespace Six.Test.Selenium.WebDriver.WebElements
{
    public class ButtonElement : WebElement
    {
        public ButtonElement(OpenQA.Selenium.IWebElement webElement) : base(webElement)
        {
            //if (!(webElement.TagName.Equals("input") && webElement.GetAttribute("type").Equals(Type())))
            //    throw new NotButtonElementException(webElement.TagName, webElement.GetCssValue("type"));
        }
    }
}