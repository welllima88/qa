using System;
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension
{
    /// <summary>
    /// This class adds to the common extension of WebElementAdapter just for suggestors. Because they will not be used in future, they are considered as separate class and interface.
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
            // these suggestors are soooo ?x$*! -> disabled the click on this element
            // driver.FindElement(By.CssSelector("div.suggestBox div div[textContent='" + text + "'].active")).Click();
            // click | //div[@inttext="Englisch [en]"] |         
            TypeText(innerText);

            // f*** o**:
            //_driver.WaitForElementPresent(By.XPath("//div[@class='suggestBox']")).Click();
            IWebElement suggestElement;
            try
            {
                //IWebElement e = _driver.WaitForElementPresent(By.XPath("//div[@inttext='" + intValue + "']"));
                //IWebElement e = _driver.WaitForElementPresent(By.CssSelector("div[intvalue='" + "CH"+ "']"));
                //IWebElement e = _driver.WaitForElementPresent(By.CssSelector("div[intvalue='" + intValue + "']"));
                suggestElement =
                    _driver.WaitForElementPresent(By.CssSelector("div.suggestBox div.item[inttext='" + innerText + "']"));
                suggestElement.Click();
            }
                //catch (NoSuchElementException)
            catch (Exception ex)
            {
                Console.Error.WriteLine("failure: skip 'click' on suggestor element [" + innerText + "] " + ex.Message);
            }
            //_driver.WaitForElementPresent(By.CssSelector("div.suggestBox div div")).Click();                        
        }

        #endregion
    }
}