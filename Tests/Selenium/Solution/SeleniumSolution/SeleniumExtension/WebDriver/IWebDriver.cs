using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Test.Selenium.WebDriver
{
    public interface IWebDriver : OpenQA.Selenium.IWebDriver
    {
        IEnumerable<IWebElement> FindAdaptedElements(By by);
        IWebElement FindAdaptedElement(By by);
        WebDriverWait WebDriverWait();
    }
}