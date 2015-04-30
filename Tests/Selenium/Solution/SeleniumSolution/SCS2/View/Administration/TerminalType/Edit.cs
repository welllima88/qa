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
    }
}