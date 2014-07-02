using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Administration.Agency
{
    public class AgencyCreate : WebObject
    {
        public static ButtonElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input.button#save")).Button(); }
        }

        public static string SbsAgentId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_SBSAgentId")).Text; }
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_SBSAgentId")).TextField().TypeText(value); }
        }

        public static string Telephone
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_PhoneNumber")).Text; }
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#Agency_PhoneNumber")).TextField().TypeText(value); }
        }

        public static string Language
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("select#Agency_LanguageId"))
                        .Selector()
                        .SelectedOption.Text;
            }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#Agency_LanguageId")).Selector().SelectByValue(value);
            }
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
                    WebDriver.FindAdaptedElement(By.CssSelector("select#Agency_CountryId"))
                        .Selector()
                        .SelectedOption.Text;
            }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#Agency_CountryId")).Selector().SelectByValue(value);
            }
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
                        .SelectedOption.Text;
            }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#Agency_SupplierMandantId"))
                    .Selector()
                    .SelectByText(value);
            }
        }
    }
}