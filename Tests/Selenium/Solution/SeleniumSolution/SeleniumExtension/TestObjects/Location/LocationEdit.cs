using System;
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Location
{
    public class LocationEdit : WebObject
    {
        public static IWebElement SaveButton
        {
            get { return LocationCreate.SaveButton; }
        }

        public static IWebElement CancelButton
        {
            get { return WebDriver.FindElement(By.CssSelector("button[name='cancel']")); }
        }

        public static string SapNumber
        {
            set { LocationCreate.SapNumber = value; }
            get { return LocationCreate.SapNumber; }
        }

        public static string CompanyName
        {
            set { LocationCreate.CompanyName = value; }
            get { return LocationCreate.CompanyName; }
        }

        public static String SbsDebitNumber
        {
            get { return LocationView.SbsDebitNumber; }
        }

        public static String SbsAdressNumber
        {
            get { return LocationView.SbsAdressNumber; }
        }

        public static String Ep2MerchantId
        {
            get { return LocationView.Ep2MerchantId; }
            set { throw new NotSupportedException(); }
        }

        public static string StreetNo
        {
            set { LocationCreate.StreetNo = value; }
            get { return LocationCreate.StreetNo; }
        }

        public static string Language
        {
            set { LocationCreate.Language = value; }
            get { return LocationCreate.Language; }
        }

        public static string Country
        {
            set { LocationCreate.Country = value; }
            get { return LocationCreate.Country; }
        }

        public static string Zip
        {
            set { LocationCreate.Zip = value; }
            get { return LocationCreate.Zip; }
        }

        public static string City
        {
            set { LocationCreate.City = value; }
            get { return LocationCreate.City; }
        }

        public static string AdressAddition
        {
            set { LocationCreate.AdressAddition = value; }
            get { return LocationCreate.AdressAddition; }
        }

        public static string Po
        {
            set { LocationCreate.Po = value; }
            get { return LocationCreate.Po; }
        }

        public static string Region
        {
            set { LocationCreate.Region = value; }
            get { return LocationCreate.Region; }
        }

        public static string Telephone
        {
            set { LocationCreate.Telephone = value; }
            get { return LocationCreate.Telephone; }
        }

        public static string Mobile
        {
            set { LocationCreate.Mobile = value; }
            get { return LocationCreate.Mobile; }
        }

        public static string Fax
        {
            set { LocationCreate.Fax = value; }
            get { return LocationCreate.Fax; }
        }

        public static string Email
        {
            set { LocationCreate.Email = value; }
            get { return LocationCreate.Email; }
        }

        public static string Web
        {
            set { LocationCreate.Web = value; }
            get { return LocationCreate.Web; }
        }

        public static string Guid
        {
            get { return WebDriver.FindElement(By.CssSelector(LocationRes.GUID)).Text; }
        }

        public static string Reason
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.Id("LocationData_NotificationReason"))
                             .Selector()
                             .SelectedOption.Text;
            }
            set { WebDriver.FindAdaptedElement(By.Id("LocationData_NotificationReason")).Selector().SelectByValue(value); }
        }

        public static string ReasonRemark
        {
            get { return WebDriver.FindAdaptedElement(By.Id("LocationData_NotificationRemarks")).Text; }
            set { WebDriver.FindAdaptedElement(By.Id("LocationData_NotificationRemarks")).TextBox().TypeText(value); }
        }
    }
}