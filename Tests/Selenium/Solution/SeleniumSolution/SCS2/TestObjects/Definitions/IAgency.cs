﻿namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions
{
    internal interface IAgency : IAdress
    {
        string Name { get; set; }
        string DisplayName { get; set; }
        string Supplier { get; set; }
    }
}