using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.User
{
    public class View : WebObject
    {
        public static string UserName
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Username")).Text; }
        }

        public static string Password
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Password")).Text; }
        }

        public static string Salutation
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Salutation")).Text; }
        }

        public static string FirstName
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Firstname")).Text; }
        }

        public static string Name
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Name")).Text; }
        }

        public static string Email
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Email")).Text; }
        }

        public static string Language
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Language")).Text; }
        }

        public static string SecurId
        {
            get { return WebDriver.FindAdaptedElement(By.Id("SecureId")).Text; }
        }

        public static string WesMandant
        {
            get { return WebDriver.FindAdaptedElement(By.Id("WesMandant")).Text; }
        }

        public static string State
        {
            get { return WebDriver.FindAdaptedElement(By.Id("State")).Text; }
        }

        public static string Created
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Created")).Text; }
        }

        public static string LastLogOn
        {
            get { return WebDriver.FindAdaptedElement(By.Id("LastLogin")).Text; }
        }

        public static string Comment
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Comment")).Text; }
        }

        public static IWebElementAdapter EditButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("edit")); }
        }

        public static IWebElementAdapter ReactivateButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("reactivate")); }
        }

        public static ButtonElement ResetPasswordConfirm
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button#reset")).Button(); }
        }

        public static IWebElementAdapter AddServiceButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href*='/User/SetupLoginService?userName=']")); }
        }
    }
}