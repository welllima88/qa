using OpenQA.Selenium.Support.PageObjects;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Saferpay.Backoffice.Test.Pages.Payment
{
    public class Booking
    {
        [FindsBy(How = How.Id, Using = "CardNumber")]
        public static IWebElementAdapter CardNumber;

        [FindsBy(How = How.Id, Using = "ExpiryMonth")]
        public static IWebElementAdapter ExpiryMonth;

        [FindsBy(How = How.Id, Using = "ExpiryYear")]
        public static IWebElementAdapter ExpiryYear;

        [FindsBy(How = How.Id, Using = "C-HolderName")]
        public static IWebElementAdapter CardHolderName;

        [FindsBy(How = How.Id, Using = "VerificationCode")]
        public static IWebElementAdapter VerificationCode;

        [FindsBy(How = How.Id, Using = "C-Currency")]
        public static IWebElementAdapter Currency;

        [FindsBy(How = How.Id, Using = "C-Amount")]
        public static IWebElementAdapter Amount;

        [FindsBy(How = How.Id, Using = "C-OrderId")]
        public static IWebElementAdapter OrderId;

        [FindsBy(How = How.Id, Using = "C-Description")]
        public static IWebElementAdapter Description;

        [FindsBy(How = How.Id, Using = "C-PayerNote")]
        public static IWebElementAdapter PayerNote;

        [FindsBy(How = How.CssSelector, Using = "button")]
        public static IWebElementAdapter Pay;
    }
}