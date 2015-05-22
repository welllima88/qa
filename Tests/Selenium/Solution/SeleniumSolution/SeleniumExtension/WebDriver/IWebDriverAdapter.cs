using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Test.Selenium.WebDriver
{
    public interface IWebDriverAdapter : IWebDriver
    {
        IEnumerable<IWebElementAdapter> FindAdaptedElements(By by);
        IWebElementAdapter FindAdaptedElement(By by);
        IEnumerable<string> WebElementsAsStringList(IEnumerable<IWebElementAdapter> webElements);
        WebDriverWait WebDriverWait();
    }
}