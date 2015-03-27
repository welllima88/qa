using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Administration.Agency
{
    public class Create : WebObject
    {
        public static ButtonElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")).Button(); }
        }

        public static string SbsAgentId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_SBSAgentId")).Text; }
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_SBSAgentId")).TextField().TypeText(value); }
        }

        public static string StreetNo
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_Street")).Text; }
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_Street")).TextField().TypeText(value); }
        }

        public static string Country
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.Id("Agency_CountryId"))
                        .Selector()
                        .SelectedOption;
            }
            set { WebDriver.FindAdaptedElement(By.Id("Agency_CountryId")).Selector().SelectByText(value); }
        }

        public static string Zip
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_ZIP")).Text; }
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_ZIP")).TextField().TypeText(value); }
        }

        public static string City
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_City")).Text; }
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_City")).TextField().TypeText(value); }
        }

        public static string Name
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_AgencyName")).Text; }
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_AgencyName")).TextField().TypeText(value); }
        }

        public static string DisplayName
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_AgencyUserDefinedName")).Text; }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_AgencyUserDefinedName"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public static string Supplier
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("select#Agency_SupplierMandantId"))
                        .Selector()
                        .SelectedOption;
            }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#Agency_SupplierMandantId"))
                    .Selector()
                    .SelectByText(value);
            }
        }

        public static bool Status
        {
            set { WebDriver.FindAdaptedElement(By.Id("Agency_IsActive")).CheckBox().Set(value); }
        }
    }
}