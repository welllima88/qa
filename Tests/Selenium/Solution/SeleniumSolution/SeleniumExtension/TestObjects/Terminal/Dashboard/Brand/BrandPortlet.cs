using System.Collections.Generic;
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard.Brand
{
    public class BrandPortlet : PortletViewBase
    {
        public List<Acquirer> Acquirers;
        public Pms Pms;
        public ServiceCenter ServiceCenter;

        public BrandPortlet()
        {
            ServiceCenter = new ServiceCenter();
            Pms = new Pms();
            Acquirers = new List<Acquirer>(5);
        }

        public static IWebElement NewBrandButton
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "div#frame_BrandPortlet div.portletLinks a[href*=\'/Contract/ContractNew.aspx?TerminalId=\']"));
            }
        }

        public static IWebElement Brand(string brandId)
        {
            return
                WebDriver.FindAdaptedElement(
                    By.CssSelector(string.Format(
                        "div#frame_BrandPortlet div#contractTree ul li[id='brandContract_{0}']", brandId)));
        }
    }
}