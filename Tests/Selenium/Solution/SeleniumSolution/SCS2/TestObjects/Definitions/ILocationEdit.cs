using System;
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.TestObjects
{
    public interface ILocationEdit
    {
        string SapNumber { set; }
        string CompanyName { set; }
        String SbsDebitNumber { get; }
        String SbsAdressNumber { get; }
        String Ep2MerchantId { get; }
        string StreetName { set; }
        string Language { set; }
        string Country { set; }
        string Zip { set; }
        string City { set; }
        string AdressAddition { set; }
        string Po { set; }
        string Region { set; }
        string Telephone { set; }
        string Mobile { set; }
        string Fax { set; }
        string Email { set; }
        string Web { set; }
        IWebElement SaveButton { get; }
        IWebElement CancelButton { get; }
        string Guid { get; }
    }
}