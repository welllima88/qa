using OpenQA.Selenium;

namespace Six.Scs.Test.UI.Terminal.Dashboard.Portlets
{
    public class QuickOpen : PortletBase
    {
        public QuickOpen()
        {
            PortletId = "div#frame_TerminalIdSearchPortlet";
        }

        public static string OpenTerminalId
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(Prefix + PortletId + "input#Query"))
                    .TextField()
                    .TypeText(value);
                WebDriver.FindAdaptedElement(By.CssSelector(Prefix + PortletId + "span>button[type='submit']")).Click();
                AllHasBeenLoaded();
            }
        }

        public static string Info
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector(Prefix + PortletId + "form#terminalIdSearchForm div p")).Text;
            }
        }
    }
}