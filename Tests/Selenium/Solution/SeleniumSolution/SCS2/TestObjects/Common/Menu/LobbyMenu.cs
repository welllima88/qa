using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu
{
    /// <summary>
    /// css Locator have problems with menu so use xpath until resolved the reason...
    /// </summary>
    public class LobbyMenu : MenuObject
    {
        public CustomerMenu Customer;
        public LocationMenu LocationMenu;
        public MassMutationMenu MassMutation;
        public TerminalMenu TerminalMenu;
        public TicketMenu Ticket;
        public SimCardMenu SimCardMenu;

        public LobbyMenu(IWebDriverAdapter driver) : base(driver)
        {
            MassMutation = new MassMutationMenu(Driver);
            Customer = new CustomerMenu(Driver);
            LocationMenu = new LocationMenu(Driver);
            TerminalMenu = new TerminalMenu(Driver);
            Ticket = new TicketMenu(Driver);
        }

        public IWebElement Lobby
        {
            get { return Driver.FindElement(By.CssSelector(Menu.LobbyMenu_Lobby)); }
        }
    }
}