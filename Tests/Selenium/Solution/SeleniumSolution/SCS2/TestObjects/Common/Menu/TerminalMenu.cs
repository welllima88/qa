using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu
{
    public class TerminalMenu : MenuObject
    {
        public TerminalAnalysisMenu AnalysisMenu;

        public TerminalMenu(IWebDriverAdapter driver) : base(driver)
        {
            AnalysisMenu = new TerminalAnalysisMenu(Driver);
        }

        public IWebElement Terminal
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector("a[href*='/Terminal/TerminalView.aspx?PageMode=view&TERMINALID=']"));
            }
        }

        public IWebElement ContractCreate
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/Contract/ContractNew.aspx?TERMINALID=']")); }
        }

        public IWebElement InfotextCreate
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/InfoText/TerminalInfoTextNew.aspx?TERMINALID=']")); }
        }

        public IWebElement TicketCreate
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/ticket.asp?WindowName=NewTicket&CUSTOMERID=']")); }
        }

        public IWebElement ServiceCenterCreate
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/Contract/ServiceCenterCreate.aspx?']")); }
        }

        public IWebElement PmsCreate
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/Contract/PMSCreate.aspx?']")); }
        }

        public IWebElement Edit
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector("a[href*='/Terminal/TerminalView.aspx?PageMode=edit&TERMINALID=']"));
            }
        }

        public IWebElement Quit
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/Terminal/?TERMINALID=']")); }
        }

        public IWebElement Duplicate
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/Terminal/TerminalDuplicate.aspx?']")); }
        }

        public IWebElement Replace
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/Terminal/TerminalReplace.aspx?TERMINALID=']")); }
        }

        public IWebElement Tickets
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/TicketList.asp?ListType=terminal&TERMINALID=']")); }
        }

        public IWebElement Infotexts
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/InfoText/TerminalInfoTextList.aspx?TERMINALID=']")); }
        }

        public IWebElement Forms
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/Terminal/TerminalForms.aspx?TERMINALID=']")); }
        }
    }
}