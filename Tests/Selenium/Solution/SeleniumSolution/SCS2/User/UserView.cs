using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.User
{
    public class UserView : WebObject
    {
        public static string UserName
        {
            get { return WebDriver.FindAdaptedElement(By.Id("User_Username")).Text; }
        }

        public static string Password
        {
            get { return WebDriver.FindAdaptedElement(By.Id("User_Password")).Text; }
        }

        public static string Salutation
        {
            get { return WebDriver.FindAdaptedElement(By.Id("User_Salutation")).Text; }
        }

        public static string FirstName
        {
            get { return WebDriver.FindAdaptedElement(By.Id("User_FirstName")).Text; }
        }

        public static string Name
        {
            get { return WebDriver.FindAdaptedElement(By.Id("User_LastName")).Text; }
        }

        public static string Email
        {
            get { return WebDriver.FindAdaptedElement(By.Id("User_Email")).Text; }
        }

        public static string Language
        {
            get { return WebDriver.FindAdaptedElement(By.Id("User_Language")).Text; }
        }

        public static string SecurId
        {
            get { return WebDriver.FindAdaptedElement(By.Id("User_SecureId")).Text; }
        }

        public static string WesMandant
        {
            get { return WebDriver.FindAdaptedElement(By.Id("User_WesMandant")).Text; }
        }

        public static string State
        {
            get { return WebDriver.FindAdaptedElement(By.Id("User_State")).Text; }
        }

        public static string Created
        {
            get { return WebDriver.FindAdaptedElement(By.Id("User_Created")).Text; }
        }

        public static string LastLogOn
        {
            get { return WebDriver.FindAdaptedElement(By.Id("User_LastLogin")).Text; }
        }

        public static string Comment
        {
            get { return WebDriver.FindAdaptedElement(By.Id("User_Comment")).Text; }
        }

        public static IWebElementAdapter EditButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("edit")); }
        }

        public static IWebElementAdapter ReactivateButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("reactivate")); }
        }
    }
}