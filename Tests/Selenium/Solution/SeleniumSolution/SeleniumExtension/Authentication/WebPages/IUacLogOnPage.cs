using OpenQA.Selenium;

namespace Six.Scs.QA.Selenium.Extension.Authentication.Webpages
{
    public interface IUacLogOnPage
    {
        string UserName { set; }
        string UserPasswort { set; }
        IWebElement LoginButton { get; }
    }
}