using System.Diagnostics;
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.Selenium.WebElements
{
    /// <summary>
    ///     This class adds to the common extension of WebElementAdapter just for suggestors. Because they will not be used in future, they are considered as separate class and interface.
    /// </summary>
    public class SuggestorWebElementAdapter : WebObject
    {
        private readonly IWebElementAdapter _webElement;

        public SuggestorWebElementAdapter(IWebElementAdapter webElement)
        {
            _webElement = webElement;
        }

        public void TypeAndChoose(string innerText)
        {
            _webElement.TextBox().TypeText(innerText);
            try
            {
                IWebElement suggestElement =
                    WebDriver.WaitForElementPresent(
                        By.CssSelector("div.suggestBox div.item[inttext*='" + innerText + "']"));
                suggestElement.Click();
            }
            catch (NoSuchElementException ex) // hope no other exceptions occur
            {
                Debug.WriteLine("Warning: skip click - on suggestor [" + innerText + "] " + ex.Message);
            }
            catch (ElementNotVisibleException ex) // hope no other exceptions occur
            {
                Debug.WriteLine("Error: skip click - suggestor [" + innerText + "] " + ex.Message);
            }
        }
    }
}