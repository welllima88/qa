using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects
{
    public interface IWebObject
    {
        IWebDriverAdapter Driver { get; }
    }
}