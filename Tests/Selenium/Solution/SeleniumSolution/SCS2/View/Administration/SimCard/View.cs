using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Administration.SimCard
{
    public class View : WebObject
    {
        public static ButtonElement LockButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("lock")).Button(); }
        }

        public static ButtonElement UnlinkButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a#unlink")).Button(); }
        }

        public static ButtonElement EditButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("edit")).Button(); }
        }

        public static ButtonElement CreateButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href$='/SIMCard/New']")).Button(); }
        }

        public static ButtonElement ImportButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href$='/SIMCard/Import']")).Button(); }
        }

        public static string NetProvider
        {
            get { return WebDriver.FindAdaptedElement(By.Id("NetworkProvider")).Text; }
        }

        public static string SimCardNumber
        {
            get { return WebDriver.FindAdaptedElement(By.Id("SIMCardNumber")).Text; }
        }

        public static string MobileNumber
        {
            get { return WebDriver.FindAdaptedElement(By.Id("MobileNumber")).Text; }
        }

        public static string Pin
        {
            get { return WebDriver.FindAdaptedElement(By.Id("PIN")).Text; }
        }

        public static string Puk
        {
            get { return WebDriver.FindAdaptedElement(By.Id("PUK")).Text; }
        }

        public static bool Status
        {
            get { return !WebDriver.FindAdaptedElement(By.Id("SIMCard_State")).Text.Contains("in"); }
        }

        public static string TerminalId
        {
            get { return WebDriver.FindAdaptedElement(By.Id("TerminalId")).Text; }
        }

        public static string Region
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Location")).Text; }
        }

        public static string Usage
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Usage")).Text; }
        }
    }
}