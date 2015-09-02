using System.Linq;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Common.Menu
{
    /// <summary>
    ///     css Locator have problems with menu so use xpath until resolved the reason...
    /// </summary>
    public class LobbyMenu : WebObject
    {
        public static IWebElement Lobby
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href*='/Lobby/']")); }
        }

        public static IWebElement SimCardManage
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href*='/SIMCard']")); }
        }

        public static IWebElement SerialNumberManage
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href$='/SerialNumberManagement/']"));
            }
        }

        public static IWebElement AccessoireOrders
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href$='/AccessoriesOrder/List/']"));
            }
        }

        public static IWebElement HardwareManage
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href$='/HWManagement/SingleDevice']"));
            }
        }

        public static IWebElement AcccessoiresOrders
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href$='/AccessoireShop/AccessoireOrder/List/']"));
            }
        }

        public static IWebElement MyIncidents
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href$='/TroubleTicket/Incident/Supporter']"));
            }
        }

        public static IWebElement MyTeams
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href$='/TroubleTicket/Incident/Teams']"));
            }
        }

        public static IWebElement TerminalReturnShipping
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href$='/TerminalReturnShipping/']"));
            }
        }

        public static void Expand(string menuName)
        {
            // css=td#leftHandMenu a+div>a[href*='/MassMutation/']
            var massMenu =
                WebDriver.FindElements(
                    By.CssSelector(
                        "tbody tr#rowContent td#leftHandMenu span#ctl00_trvNavigation a.level2:not(.open) td"))
                    .FirstOrDefault(e => e.Text.Contains(menuName));

            if (massMenu != null) massMenu.Click();
        }
    }
}