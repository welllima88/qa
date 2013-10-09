using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu
{
    /// <summary>
    ///     css Locator have problems with menu so use xpath until resolved the reason...
    /// </summary>
    public class LobbyMenu : MenuObject
    {
        public readonly CustomerMenu Customer;
        public LocationMenu LocationMenu;
        public MassMutationMenu MassMutation;
        public SimCardMenu SimCard;
        public TerminalMenu TerminalMenu;
        public TicketMenu Ticket;

        public LobbyMenu()
        {
            MassMutation = new MassMutationMenu();
            Customer = new CustomerMenu();
            LocationMenu = new LocationMenu();
            TerminalMenu = new TerminalMenu();
            Ticket = new TicketMenu();
        }

        public IWebElement Lobby
        {
            get { return WebDriver.FindElement(By.CssSelector(Menu.LobbyMenu_Lobby)); }
        }
    }
}