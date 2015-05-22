using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Test.Selenium.WebDriver
{
    /// <summary>
    ///     This WebDriver adapter adds one method to make use of adapted web elements
    /// </summary>
    public class WebDriverAdapter : IWebDriverAdapter
    {
        private readonly IWebDriver _webDriver;

        public WebDriverAdapter(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        /// <summary>
        /// </summary>
        /// <param name="by"></param>
        /// <returns></returns>
        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return _webDriver.FindElements(by);
        }

        public IEnumerable<IWebElementAdapter> FindAdaptedElements(By by)
        {
            var webElements = _webDriver.FindElements(by);
            var list = new Collection<IWebElementAdapter>();

            // convert:
            foreach (var webElement in webElements)
            {
                list.Add(new WebElementAdapter(webElement));
            }

            return new ReadOnlyCollection<IWebElementAdapter>(list);
        }

        public IWebElementAdapter FindAdaptedElement(By by)
        {
            try
            {
                return new WebElementAdapter(_webDriver.FindElement(by));
            }
            catch (NotFoundException)
            {
                // _webDriver.TakeScreenshot().SaveAsFile("failure", ImageFormat.Png);
                Debug.Print(_webDriver.PageSource);
                throw;
            }
        }

        IEnumerable<string> IWebDriverAdapter.WebElementsAsStringList(IEnumerable<IWebElementAdapter> webElements)
        {
            return WebElementsAsStringList(webElements);
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

        public IWebElement FindElement(By by)
        {
            return _webDriver.FindElement(by);
        }

        public WebDriverWait WebDriverWait()
        {
            var wait = new WebDriverWait(_webDriver,
                TimeSpan.FromSeconds(TestDirector.TestEnvironment.SeleniumConfig.Timeouts.SetScriptTimeout));
            wait.IgnoreExceptionTypes(typeof (StaleElementReferenceException));
            return wait;
        }

        /// <summary>
        /// </summary>
        /// <param name="webElements">css locator string to return the list of web elements as strings with containing text</param>
        /// <returns></returns>
        public static IEnumerable<string> WebElementsAsStringList(IEnumerable<IWebElementAdapter> webElements)
        {
            return webElements.Select(item => item.Text).ToList();
        }
    }
}