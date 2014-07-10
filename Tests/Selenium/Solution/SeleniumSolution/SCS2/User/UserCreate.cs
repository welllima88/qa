using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.User
{
    public class UserCreate : WebObject
    {
        public static string UserName
        {
            set { WebDriver.FindAdaptedElement(By.Id("UserData_Username")).TextField().TypeText(value); }
        }

        public static string Salutation
        {
            set { WebDriver.FindAdaptedElement(By.Id("UserData_SalutationId")).Selector().SelectByText(value); }
        }

        public static string FirstName
        {
            set { WebDriver.FindAdaptedElement(By.Id("UserData_Firstname")).TextField().TypeText(value); }
        }

        public static string Name
        {
            set { WebDriver.FindAdaptedElement(By.Id("UserData_Name")).TextField().TypeText(value); }
        }

        public static string Email
        {
            set { WebDriver.FindAdaptedElement(By.Id("email")).TextField().TypeText(value); }
        }

        public static string Language
        {
            set { WebDriver.FindAdaptedElement(By.Id("UserData_LanguageId")).Selector().SelectByText(value); }
        }

        public static string SecurId
        {
            set { WebDriver.FindAdaptedElement(By.Id("UserData_SecureId")).TextField().TypeText(value); }
        }

        public static string WesMandant
        {
            set { WebDriver.FindAdaptedElement(By.Id("UserData_WESMandantId")).Selector().SelectByText(value); }
        }

        public static string Comment
        {
            set { WebDriver.FindAdaptedElement(By.Id("description")).TextField().TypeText(value); }
        }
        public static IWebElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")); }
        }
    }
}