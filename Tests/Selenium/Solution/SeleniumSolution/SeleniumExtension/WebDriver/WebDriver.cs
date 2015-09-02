using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = OpenQA.Selenium.IWebElement;

namespace Six.Test.Selenium.WebDriver
{
    /// <summary>
    ///     This WebDriver adapter adds one method to make use of adapted web elements
    /// </summary>
    public class WebDriver : IWebDriver
    {
        private readonly OpenQA.Selenium.IWebDriver _webDriver;

        public WebDriver(OpenQA.Selenium.IWebDriver webDriver)
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

        public IEnumerable<WebElements.IWebElement> FindAdaptedElements(By by)
        {
            var webElements = _webDriver.FindElements(by);
            var list = new Collection<WebElements.IWebElement>();

            // convert:
            foreach (var webElement in webElements)
            {
                list.Add(new WebElement(webElement));
            }

            return new ReadOnlyCollection<WebElements.IWebElement>(list);
        }

        public WebElements.IWebElement FindAdaptedElement(By by)
        {
            try
            {
                return new WebElement(_webDriver.FindElement(by));
            }
            catch (NotFoundException)
            {
                //((RemoteWebDriver) _webDriver)
                //    .GetScreenshot()
                //    .SaveAsFile(string.Format("{0}_{1}", "NotFoundException", "2"), ImageFormat.Png);

                Console.Error.WriteLine(_webDriver.PageSource);
                throw;
            }
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

        public EventFiringWebDriver EventFiringWebDriver()
        {
            return new EventFiringWebDriver(_webDriver);
        }
    }
}