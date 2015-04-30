using OpenQA.Selenium;

namespace Six.Test.Selenium.WebDriver.WebElements
{
    /// <summary>
    ///     A multiline text-field
    /// </summary>
    public class TextAreaElement : TextFieldElement
    {
        public TextAreaElement(IWebElement webElement)
        {
            if (!(webElement.TagName.Equals("textarea")))
                throw new NotTextAreaElementException(webElement.TagName);
            WebElement = webElement;
        }
    }
}