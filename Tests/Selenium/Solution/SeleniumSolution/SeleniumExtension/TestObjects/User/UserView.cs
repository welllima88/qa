using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.User
{
    public class UserView : WebObject
    {
        public static string UserName
        {
            get { return WebDriver.FindElement(By.Id("User_Username")).Text; }
        }

        public static string Password
        {
            get { return WebDriver.FindElement(By.Id("User_Password")).Text; }
        }

        public static string Salutation
        {
            get { return WebDriver.FindElement(By.Id("User_Salutation")).Text; }
        }

        public static string FirstName
        {
            get { return WebDriver.FindElement(By.Id("User_FirstName")).Text; }
        }

        public static string LastName
        {
            get { return WebDriver.FindElement(By.Id("User_LastName")).Text; }
        }

        public static string Email
        {
            get { return WebDriver.FindElement(By.Id("User_Email")).Text; }
        }

        public static string Language
        {
            get { return WebDriver.FindElement(By.Id("User_Language")).Text; }
        }

        public static string SecureId
        {
            get { return WebDriver.FindElement(By.Id("User_SecureId")).Text; }
        }

        public static string WesMandant
        {
            get { return WebDriver.FindElement(By.Id("User_WesMandant")).Text; }
        }

        public static string State
        {
            get { return WebDriver.FindElement(By.Id("User_State")).Text; }
        }

        public static string Created
        {
            get { return WebDriver.FindElement(By.Id("User_Created")).Text; }
        }

        public static string LastLogin
        {
            get { return WebDriver.FindElement(By.Id("User_LastLogin")).Text; }
        }

        public static string Comment
        {
            get { return WebDriver.FindElement(By.Id("User_Comment")).Text; }
        }

        public static IWebElement EditButton
        {
            get { return WebDriver.FindElement(By.Id("edit")); }
        }

        public static IWebElement ListUsersButton
        {
            get { return WebDriver.FindElement(By.Id("userList")); }
        }

        public static IWebElement ReactivateButton
        {
            get { return WebDriver.FindElement(By.Id("reactivate")); }
        }
    }
}