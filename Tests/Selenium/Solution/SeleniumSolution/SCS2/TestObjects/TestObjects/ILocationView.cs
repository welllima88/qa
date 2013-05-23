﻿using System;
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.TestObjects
{
    public interface ILocationView
    {
        string CompanyName { get; }
        string Guid { get; }
        string StreetName { get; }
        string Zip { get; }
        string City { get; }
        String SbsDebitNumber { get; }
        String SbsAdressNumber { get; }
        string Language { get; }
        string Country { get; }
        string Ep2MerchantId { get; }
        string SapNumber { get; }
        string Po { get; }
        string AdressAddition { get; }
        string Email { get; }
        string Web { get; }
        string Telephone { get; }
        string Mobile { get; }
        string Fax { get; }
        IWebElement EditButton { get; }
        string Region { get; }
    }
}