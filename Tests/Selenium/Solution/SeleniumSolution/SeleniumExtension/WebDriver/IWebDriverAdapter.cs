using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Test.Selenium.WebDriver
{
    public interface IWebDriverAdapter : IWebDriver
    {
        ReadOnlyCollection<IWebElementAdapter> FindAdaptedElements(By by);
        IWebElementAdapter FindAdaptedElement(By by);
        List<string> WebElementsAsStringList(IEnumerable<IWebElementAdapter> webElements);
        WebDriverWait WebDriverWait();
    }
}