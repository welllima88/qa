using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Test.Selenium.WebDriver
{
    public interface IWebDriver : OpenQA.Selenium.IWebDriver
    {
        IEnumerable<IWebElementAdapter> FindAdaptedElements(By by);
        IWebElementAdapter FindAdaptedElement(By by);
        WebDriverWait WebDriverWait();
    }
}