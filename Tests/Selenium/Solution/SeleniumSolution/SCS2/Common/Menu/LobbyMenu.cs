using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common.Menu
{
    /// <summary>
    ///     css Locator have problems with menu so use xpath until resolved the reason...
    /// </summary>
    public class LobbyMenu : WebObject
    {
        public static IWebElementAdapter Lobby
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.LobbyMenu_Lobby)); }
        }

        public static IWebElementAdapter SimCardManage
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.SimCardManagement)); }
        }

        public static IWebElementAdapter SerialNumberManage
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href$='/SerialNumberManagement/']")); }
        }

        public static IWebElementAdapter BillableTerminalsMenu
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href$='/BillableTerminals/']")); }
        }

        public static IWebElementAdapter PostDeliveryTickets
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href$='/DeliveryTicketsPost/']")); }
        }

        public static IWebElementAdapter AccessoireOrders
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href$='/AccessoriesOrder/List/']")); }
        }

        public static IWebElementAdapter HardwareManage
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href$='/HWManagement']")); }
        }

        public static IWebElementAdapter AcccessoiresOrders
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href$='/AccessoriesOrder/List/']")); }
        }
    }
}