using System.Diagnostics;
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension
{
    /// <summary>
    ///     This class adds to the common extension of WebElementAdapter just for suggestors. Because they will not be used in future, they are considered as separate class and interface.
    /// </summary>
    public class SuggestorWebElementAdapter : WebElementAdapter, ISuggesterWebElement
    {
        private readonly IWebDriverAdapter _driver;

        public SuggestorWebElementAdapter(IWebElement webElement, IWebDriver webDriver) : base(webElement)
        {
            _driver = new WebDriverAdapter(webDriver);
        }

        #region ISuggesterWebElement Members

        public void Suggestor(string innerText)
        {
            TypeText(innerText);
            try
            {
                IWebElement suggestElement =
                    _driver.WaitForElementPresent(By.CssSelector("div.suggestBox div.item[inttext*='" + innerText + "']"));
                suggestElement.Click();
            }
            catch (NoSuchElementException ex) // hope no other exceptions occur
            {
                Debug.WriteLine("warning: skip 'click' on suggestor element [" + innerText + "] " + ex.Message);
            }
        }

        #endregion
    }
}