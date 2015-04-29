using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Administration.TerminalType
{
    public class Edit : WebObject
    {
        public static ButtonElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")).Button(); }
        }

        public static IEnumerable<string> AvailableSuppliers
        {
            get
            {
                return
                    WebDriver.FindAdaptedElements(
                        By.CssSelector("td#content div#ms-supplier-mandants div.ms-selectable ul.ms-list li.ms-elem-selectable span"))
                        .Select(e => e.Text);
            }
            set
            {
                foreach (var supplier in value)
                {
                    WebDriver.FindAdaptedElements(
                        By.CssSelector("td#content div#ms-supplier-mandants div.ms-selectable ul.ms-list li.ms-elem-selectable span"))
                        .FirstOrDefault(e => e.Text.Equals(supplier)).Click();
                }
            }
        }

        public static IEnumerable<string> SelectedSuppliers
        {
            get
            {
                return
                    WebDriver.FindAdaptedElements(
                        By.CssSelector("td#content div#ms-supplier-mandants div.ms-selection ul.ms-list li.ms-elem-selection.ms-selected span"))
                        .Select(e => e.Text);
            }
            set
            {
                foreach (var supplier in value)
                {
                    WebDriver.FindAdaptedElements(
                        By.CssSelector("td#content div#ms-supplier-mandants div.ms-selection ul.ms-list li.ms-elem-selection.ms-selected span"))
                        .FirstOrDefault(e => e.Text.Equals(supplier)).Click();
                }
            }
        }

        public static string Supplier
        {
            set { WebDriver.FindAdaptedElement(By.Id("SelectedTerminalSupplier")).Selector().SelectByText(value); }
        }

        public static string ReferenceSystem
        {
            set { WebDriver.FindAdaptedElement(By.Id("SelectedProtocol")).Selector().SelectByText(value); }
        }

        public static string Range
        {
            get

            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "td#content form div.panel.panel-default div.panel-body div.row p.form-control-static"))
                        .Text;
            }
        }

        public static string DeviceType
        {
            set { WebDriver.FindAdaptedElement(By.Id("TerminalTypeData_TerminalType")).TextField().TypeText(value); }
        }

        public static string DefaultCapabilities
        {
            set
            {
                WebDriver.FindAdaptedElement(By.Id("TerminalTypeData_TerminalCapabilitySuggestion"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public static string DefaultAdditionalCapabilities
        {
            set
            {
                WebDriver.FindAdaptedElement(By.Id("TerminalTypeData_AdditionalTerminalCapabilitySuggestion"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public static IEnumerable<string> AvailableProviders
        {
            get
            {
                return
                    WebDriver.FindAdaptedElements(
                        By.CssSelector("td#content div#ms-SelectedProviders div.ms-selectable ul.ms-list li.ms-elem-selectable span"))
                        .Select(e => e.Text);
            }
            set
            {
                foreach (var provider in value)
                {
                    WebDriver.FindAdaptedElements(
                        By.CssSelector("td#content div#ms-SelectedProviders div.ms-selectable ul.ms-list li.ms-elem-selectable span"))
                        .FirstOrDefault(e => e.Text.Equals(provider)).Click();
                }
            }
        }

        public static IEnumerable<string> SelectedProviders
        {
            get
            {
                return
                    WebDriver.FindAdaptedElements(
                        By.CssSelector("td#content div#ms-SelectedProviders div.ms-selection ul.ms-list li.ms-elem-selection.ms-selected span"))
                        .Select(e => e.Text);
            }
            set
            {
                foreach (var provider in value)
                {
                    WebDriver.FindAdaptedElements(
                        By.CssSelector("td#content div#ms-SelectedProviders div.ms-selection ul.ms-list li.ms-elem-selection.ms-selected span"))
                        .FirstOrDefault(e => e.Text.Equals(provider)).Click();
                }
            }
        }
    }
}