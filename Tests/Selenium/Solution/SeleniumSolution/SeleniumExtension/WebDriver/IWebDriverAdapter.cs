using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.QA.Selenium.Extension.WebDriver
{
    public interface IWebDriverAdapter : IWebDriver
    {
        ReadOnlyCollection<IWebElementAdapter> FindAdaptedElements(By by);
        IWebElementAdapter FindAdaptedElement(By by);
        List<string> WebElementsAsStringList(IEnumerable<IWebElementAdapter> webElements);
        WebDriverWait WebDriverWait();
    }
}