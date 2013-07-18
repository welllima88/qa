using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Tests.SCSClassics.TestObjects.Menu
{
    public class LocationMenu
    {
        private readonly IWebDriver _driver;

        public LocationMenu(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement Location
        {
            get { return _driver.FindElement(By.CssSelector("a[href*='/Location/?LOCATIONID=']")); }
        }

        public IWebElement TerminalCreate
        {
            get { return _driver.FindElement(By.CssSelector("a[href*='Terminal/TerminalNew.aspx?LOCATIONID=']")); }
        }

        public IWebElement InfotextCreate
        {
            get { return _driver.FindElement(By.CssSelector("a[href*='Default.aspx']")); }
        }

        public IWebElement ContactCreate
        {
            get { return _driver.FindElement(By.CssSelector("a[href*='Person/PersonEdit.aspx?PageMode=new&LOCATIONID=']")); }
        }

        public IWebElement LocationEdit
        {
            get { return _driver.FindElement(By.CssSelector("a[href*='Location/Edit?LOCATIONID=']")); }
        }

        public IWebElement LocationQuit
        {
            get { return _driver.FindElement(By.CssSelector("a[href*='Location.asp?mode=Cancel&LocationFunction=']")); }
        }

        public IWebElement Terminals
        {
            get { return _driver.FindElement(By.CssSelector("a[href*='Terminal/TerminalList.aspx?LOCATIONID=']")); }
        }

        public IWebElement Contacts
        {
            get
            {
                return
                    _driver.FindElement(
                        By.CssSelector("a[href*='Person/PersonList.aspx?CUSTOMERID='][href*='&LOCATIONID=']"));
            }
        }

        public IWebElement Infotexts
        {
            get { return _driver.FindElement(By.CssSelector("a[href*='InfoText/LocationInfoTextList.aspx?LOCATIONID=']")); }
        }
    }
}