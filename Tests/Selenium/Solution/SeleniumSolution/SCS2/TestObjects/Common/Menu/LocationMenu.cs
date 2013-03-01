using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu
{
    public class LocationMenu : WebObject
    {
        public LocationMenu(IWebDriverAdapter driver) : base(driver)
        {
        }

        public IWebElement Location
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/Location/?LOCATIONID=']")); }
        }


        public IWebElement TerminalCreate
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='Terminal/TerminalNew.aspx?LOCATIONID=']")); }
        }

        public IWebElement InfotextCreate
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='Default.aspx']")); }
        }

        public IWebElement ContactCreate
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='Person/PersonEdit.aspx?PageMode=new&LOCATIONID=']")); }
        }

        public IWebElement LocationEdit
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='Location/Edit?LOCATIONID=']")); }
        }

        public IWebElement LocationQuit
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='Location.asp?mode=Cancel&LocationFunction=']")); }
        }

        public IWebElement Terminals
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='Terminal/TerminalList.aspx?LOCATIONID=']")); }
        }

        public IWebElement Contacts
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector("a[href*='Person/PersonList.aspx?CUSTOMERID='][href*='&LOCATIONID=']"));
            }
        }

        public IWebElement Infotexts
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='InfoText/LocationInfoTextList.aspx?LOCATIONID=']")); }
        }
    }
}