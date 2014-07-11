using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.Dashboard.Brand
{
    public class BrandPortlet : PortletViewBase
    {
        public static IWebElementAdapter NewBrandButton
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "div#frame_BrandPortlet div.portletLinks a[href*='/CreateContract/ListByTerminal?TerminalId=']"));
            }
        }

        public static IWebElementAdapter Brand(string brandId)
        {
            return
                WebDriver.FindAdaptedElement(
                    By.CssSelector(string.Format(
                        "div#frame_BrandPortlet div#contractTree ul li[id='brandContract_{0}']", brandId)));
        }
    }
}