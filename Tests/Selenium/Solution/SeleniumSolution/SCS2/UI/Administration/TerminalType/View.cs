using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.UI.Administration.TerminalType
{
    public class View : WebObject
    {
        private const string prefix = "td#content div.panel-default div.panel-body div.row";

        public static ButtonElement EditButton
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#content div.row a.btn[href*='/TerminalType/Edit?TerminalTypeId=']"))
                        .Button();
            }
        }

        public static IEnumerable<string> Suppliers
        {
            get
            {
                return WebDriver.FindAdaptedElements(By.CssSelector("div#Suppliers dl dd")).Select(e => e.Text).ToList();
            }
        }

        public static string Supplier
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(prefix + ":nth-child(1) div:nth-child(1) p")).Text;
            }
        }

        public static string ReferenceSystem
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(prefix + ":nth-child(1) div:nth-child(2) p")).Text;
            }
        }

        public static string Range
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(prefix + ":nth-child(1) div:nth-child(4) p")).Text;
            }
        }

        public static string DeviceType
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(prefix + ":nth-child(1) div:nth-child(3) p")).Text;
            }
        }

        public static string DefaultCapabilities
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(prefix + ":nth-child(2) div:nth-child(1) p")).Text;
            }
        }

        public static string DefaultAdditionalCapabilities
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(prefix + ":nth-child(2) div:nth-child(2) p")).Text;
            }
        }

        public static IEnumerable<string> Providers
        {
            get
            {
                return (WebDriver.FindAdaptedElements(By.CssSelector("div#Providers dl dd")))
                    .Select(e => e.Text).ToList();
            }
        }

        public static IEnumerable<string> SoftwareIds
        {
            get
            {
                return
                    WebDriver.FindAdaptedElements(
                        By.CssSelector("td#content table#Softwares tbody tr td:nth-child(2)"))
                        .Select(e => e.Text).ToList();
            }
        }
    }
}