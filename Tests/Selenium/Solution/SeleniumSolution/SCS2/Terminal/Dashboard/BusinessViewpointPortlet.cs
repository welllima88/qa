using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.Dashboard
{
    public class BusinessViewpointPortlet : PortletViewBase
    {
        public static IWebElementAdapter ReceiptHeader
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("div#frame_TerminalBusinessViewpointPortlet div#BVP_ReceiptHeader"));
            }
        }

        public static string Status
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("div#frame_TerminalBusinessViewpointPortlet span#BVP_State")).Text;
            }
        }

        public static string TerminalType
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "div#frame_TerminalBusinessViewpointPortlet span#BVP_Appearance")).Text;
            }
        }

        public static string Color
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
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
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "div#frame_TerminalBusinessViewpointPortlet div#BVP_TerminalAppearance_LanguageProperty div.treeGridValueCol span"))
                        .Text;
            }
        }
    }
}