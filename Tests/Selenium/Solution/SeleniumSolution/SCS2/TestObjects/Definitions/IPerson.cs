﻿namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions
{
    public interface IPerson : IAdress, IContact
    {
        string FirstName { set; get; }
        string Name { set; get; }
        string Salutation { set; get; }
    }
}