using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets.Brand
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
                            "div#frame_EP2BrandPortlet div.portletLinks a[href*='/EP2ContractCreate/ListByTerminal?TerminalId=']"));
            }
        }

        public static IWebElementAdapter Brand(string brandId)
        {
            return
                WebDriver.FindAdaptedElement(
                    By.CssSelector(string.Format(
                        "div#frame_EP2BrandPortlet div#ep2ContractTree ul li[id^='brandContract_{0}']", brandId)));
        }

        public static IWebElementAdapter Acquirer(string acquirerId)
        {
            return
                WebDriver.FindAdaptedElement(
                    By.CssSelector(string.Format(
                        "div#frame_EP2BrandPortlet div#ep2ContractTree ul li[id^='acqContract_'] div#{0}", acquirerId)));
        }
    }
}