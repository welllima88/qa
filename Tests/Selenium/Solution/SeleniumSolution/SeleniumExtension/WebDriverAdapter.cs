using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension
{
    /// <summary>
    /// This WebDriver adapter adds one method to make use of adapted web elements
    /// </summary>
    public class WebDriverAdapter : IWebDriverAdapter
    {
        private readonly IWebDriver _webDriver;

        public WebDriverAdapter(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        #region IWebDriverAdapter Members

        public IWebElement FindElement(By by)
        {
            return _webDriver.FindElement(by);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="by"></param>
        /// <returns></returns>
        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return _webDriver.FindElements(by);
        }

        public ReadOnlyCollection<IWebElementAdapter> FindAdaptedElements(By by)
        {
            ReadOnlyCollection<IWebElement> webElements = _webDriver.FindElements(by);
            var list = new Collection<IWebElementAdapter>();

            // convert:
            foreach (IWebElement webElement in webElements)
            {
                list.Add(new WebElementAdapter(webElement));
            }

            return new ReadOnlyCollection<IWebElementAdapter>(list);
        }

        public IWebElementAdapter FindAdaptedElement(By by)
        {
            return new WebElementAdapter(_webDriver.FindElement(by));
        }

        List<string> IWebDriverAdapter.WebElementsAsStringList(ReadOnlyCollection<IWebElement> webElements)
        {
            return WebElementsAsStringList(webElements);
        }

        public ISuggesterWebElement FindSuggesterElement(By by)
        {
            return new SuggestorWebElementAdapter(_webDriver.FindElement(by),
                                                  _webDriver);
        }

        public void Dispose()
        {
            _webDriver.Dispose();
        }

        public void Close()
        {
            _webDriver.Close();
        }

        public void Quit()
        {
            _webDriver.Quit();
        }

        public IOptions Manage()
        {
            return _webDriver.Manage();
        }

        public INavigation Navigate()
        {
            return _webDriver.Navigate();
        }

        public ITargetLocator SwitchTo()
        {
            return _webDriver.SwitchTo();
        }

        public string Url
        {
            get { return _webDriver.Url; }
            set { _webDriver.Url = value; }
        }

        public string Title
        {
            get { return _webDriver.Title; }
        }

        public string PageSource
        {
            get { return _webDriver.PageSource; }
        }

        public string CurrentWindowHandle
        {
            get { return _webDriver.CurrentWindowHandle; }
        }

        public ReadOnlyCollection<string> WindowHandles
        {
            get { return _webDriver.WindowHandles; }
        }

        /// <summary>
        /// Wait for an element found by locator is displayed within the default timeout
        /// </summary>
        /// <param name="locator">locator for element for which it should be wait</param>
        /// <returns>the found element (otherwise exception)</returns>
        public IWebElement WaitForElementPresent(By locator)
        {
            return WaitForElementPresent(locator, 2);
        }

        /// <summary>
        /// Wait for an element found by locator is displayed within the given timeout
        /// </summary>
        /// <param name="locator">locator for element for which it should be wait</param>
        /// <param name="timeout">timeout [s] after how many seconds the wait shoul be canceled</param>
        /// <returns>the found element (otherwise exception)</returns>
        public IWebElement WaitForElementPresent(By locator, int timeout)
        {
            const int interval = 100;
            int retry = timeout*1000/interval; //[s]->[ms]

            do
            {
                Thread.Sleep(interval);
                IWebElement e = FindElement(locator);
                if (e.Displayed)
                {
                    return e;
                }
                retry--;
            } while (retry > 0);
            throw new NoSuchElementException(locator.ToString());
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webElements">css locator string to return the list of web elements as strings with containing text</param>
        /// <returns></returns>
        public static List<String> WebElementsAsStringList(IEnumerable<IWebElement> webElements)
        {
            var items = new List<String>(5);
            foreach (IWebElement item in webElements)
            {
                items.Add(item.Text);
            }
            return items;
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}