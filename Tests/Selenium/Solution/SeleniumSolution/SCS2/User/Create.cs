using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.User
{
    public class Create : WebObject
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
            get { return WebDriver.FindAdaptedElement(By.Id("UserData_Firstname")).TextField().Text(); }
        }

        public static string Name
        {
            set { WebDriver.FindAdaptedElement(By.Id("UserData_Name")).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("UserData_Name")).TextField().Text(); }
        }

        public static string Email
        {
            set { WebDriver.FindAdaptedElement(By.Id("UserData_Email")).TextField().TypeText(value); }
        }

        public static string Language
        {
            set { WebDriver.FindAdaptedElement(By.Id("UserData_LanguageId")).Selector().SelectByText(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("UserData_LanguageId")).Selector().SelectedOption; }
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
            set { WebDriver.FindAdaptedElement(By.Id("UserData_Comment")).TextField().TypeText(value); }
        }

        public static ButtonElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")).Button(); }
        }
    }
}