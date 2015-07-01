using OpenQA.Selenium.Support.PageObjects;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Saferpay.Backoffice.Test.Pages.Payment
{
    public class Booking
    {
        [FindsBy(How = How.Id, Using = "CardNumber")]
        public static IWebElement CardNumber;

        [FindsBy(How = How.Id, Using = "ExpiryMonth")]
        public static IWebElement ExpiryMonth;

        [FindsBy(How = How.Id, Using = "ExpiryYear")]
        public static IWebElement ExpiryYear;

        [FindsBy(How = How.Id, Using = "C-HolderName")]
        public static IWebElement CardHolderName;

        [FindsBy(How = How.Id, Using = "VerificationCode")]
        public static IWebElement VerificationCode;

        [FindsBy(How = How.Id, Using = "C-Currency")]
        public static IWebElement Currency;

        [FindsBy(How = How.Id, Using = "C-Amount")]
        public static IWebElement Amount;

        [FindsBy(How = How.Id, Using = "C-OrderId")]
        public static IWebElement OrderId;

        [FindsBy(How = How.Id, Using = "C-Description")]
        public static IWebElement Description;

        [FindsBy(How = How.Id, Using = "C-PayerNote")]
        public static IWebElement PayerNote;

        [FindsBy(How = How.CssSelector, Using = "button")]
        public static IWebElement Pay;
    }
}