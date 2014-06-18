using OpenQA.Selenium;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Terminal.Dashboard
{
    public class BusinessViewpointPortlet : PortletViewBase
    {
        public static IWebElement ReceiptHeader
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector("div#frame_TerminalBusinessViewpointPortlet div#BVP_ReceiptHeader"));
            }
        }

        public static string Status
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector("div#frame_TerminalBusinessViewpointPortlet span#BVP_State")).Text;
            }
        }

        public static string TerminalType
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(
                            "div#frame_TerminalBusinessViewpointPortlet span#BVP_Appearance")).Text;
            }
        }

        public static string Color
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(
                            "div#frame_TerminalBusinessViewpointPortlet div#BVP_TerminalColor div.treeGridValueCol span"))
                        .Text;
            }
        }

        public static string TerminalLanguage
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(
                            "div#frame_TerminalBusinessViewpointPortlet div#BVP_TerminalAppearance_LanguageProperty div.treeGridValueCol span"))
                        .Text;
            }
        }
    }
}