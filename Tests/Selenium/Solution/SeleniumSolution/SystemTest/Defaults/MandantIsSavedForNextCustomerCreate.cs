﻿using NUnit.Framework;
using Six.Scs.Test.View.Common.Menu;
using Six.Scs.Test.View.Customer;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Defaults
{
    [TestFixture]
    public class MandantIsSavedForNextCustomerCreate
    {
        [SetUp]
        public void GoToCreateCustomer()
        {
        }

        [Test]
        public void CustomerName([Values("SIX Payment Services AG", "CETREL S.A.", "easycash NSP")] string supplier)
        {
            TestDirector.Navigate();
            CustomerMenu.CustomerCreate.Click();
            Create.Supplier = supplier;
            Create.Confirm.Click();

            TestDirector.Navigate();
            CustomerMenu.CustomerCreate.Click();
            Assert.That(Create.Supplier, Is.EqualTo(supplier));
        }
    }
}