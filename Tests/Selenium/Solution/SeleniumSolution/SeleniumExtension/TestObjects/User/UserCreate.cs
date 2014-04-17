using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.User
{
    public class UserCreate : WebObject
    {
        public static string UserName
        {
            set { WebDriver.FindAdaptedElement(By.Id("User_Username")).TextBox().TypeText(value); }
        }

        public static string Salutation
        {
            set { WebDriver.FindAdaptedElement(By.Id("User_Salutation")).TextBox().TypeText(value); }
        }

        public static string FirstName
        {
            set { WebDriver.FindAdaptedElement(By.Id("User_FirstName")).TextBox().TypeText(value); }
        }

        public static string Name
        {
            set { WebDriver.FindAdaptedElement(By.Id("User_LastName")).TextBox().TypeText(value); }
        }

        public static string Email
        {
            set { WebDriver.FindAdaptedElement(By.Id("User_Email")).TextBox().TypeText(value); }
        }

        public static string Language
        {
            set { WebDriver.FindAdaptedElement(By.Id("User_Language")).TextBox().TypeText(value); }
        }

        public static string SecurId
        {
            set { WebDriver.FindAdaptedElement(By.Id("User_SecureId")).TextBox().TypeText(value); }
        }

        public static string WesMandant
        {
            set { WebDriver.FindAdaptedElement(By.Id("User_WesMandant")).TextBox().TypeText(value); }
        }

        public static string Comment
        {
            set { WebDriver.FindAdaptedElement(By.Id("User_Comment")).TextBox().TypeText(value); }
        }
        public static IWebElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")); }
        }
    }
}