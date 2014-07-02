using OpenQA.Selenium;

namespace Six.Scs.QA.Selenium.Extension.WebDriver.WebElements
{
    public class Button
    {
        private readonly IWebElement _webElement;

        public Button(IWebElement webElement)
        {
            //if (!(webElement.TagName.Equals("input") && webElement.GetAttribute("type").Equals(Type())))
            //    throw new NotButtonElementException(webElement.TagName, webElement.GetCssValue("type"));
            _webElement = webElement;
        }

        public void Click()
        {
            _webElement.Click();
        }
    }
}