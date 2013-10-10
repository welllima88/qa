using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu
{
    /// <summary>
    ///     css Locator have problems with menu so use xpath until resolved the reason...
    /// </summary>
    public class LobbyMenu : MenuObject
    {
        public static LocationMenu LocationMenu;
        public static MassMutationMenu MassMutation;
        public static SimCardMenu SimCard;
        public static TerminalMenu TerminalMenu;
        public static TicketMenu Ticket;
        public CustomerMenu Customer;

        public static IWebElement Lobby
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.LobbyMenu_Lobby)); }
        }
    }
}