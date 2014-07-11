using OpenQA.Selenium;

namespace Six.Scs.QA.Selenium.Extension.WebDriver.WebElements
{
    public class ButtonElement : WebElementAdapter
    {
        public ButtonElement(IWebElement webElement) : base(webElement)
        {
            //if (!(webElement.TagName.Equals("input") && webElement.GetAttribute("type").Equals(Type())))
            //    throw new NotButtonElementException(webElement.TagName, webElement.GetCssValue("type"));
        }
        
    }
}