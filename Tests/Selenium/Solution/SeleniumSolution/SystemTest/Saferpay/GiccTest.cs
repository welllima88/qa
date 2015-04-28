﻿using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Application.Workflow.Builder;
using Six.Scs.QA.Testlogic.Builder.Customer.Nsp;
using Six.Scs.QA.Testlogic.Builder.Location;
using Six.Scs.QA.Testlogic.Builder.Terminal.Saferpay;
using Default = Six.Scs.QA.Testlogic.Builder.Brand.Gicc.Default;

namespace Six.Scs.QA.Application.SystemTest.Saferpay
{
    [TestFixture]
    public class GiccTest
    {
        [SetUp]
        public static void TestInit()
        {
            TestDirector.Navigate();
        }

        private static Model.ValueObjects.Terminal _saferpayTerminal;
        private static CustomerBuilder _saferpayCustomer;
        private static LocationBuilder _saferpayLocation;

        [Test]
        [Category("Regression"), Category("Customer"), Category("Location"), Category("Terminal"),
         Category("Saferpay"), Category("GICC")]
        public static void GiccCustomerStructure()
        {
            _saferpayCustomer = Testlogic.Customer.Create(new SixNsp());
            _saferpayLocation = Testlogic.Location.Create(_saferpayCustomer.Customer, new Gicc());
            _saferpayTerminal = Testlogic.Terminal.Create(_saferpayLocation.Location,
                new Icp().With(new Default()));
        }
    }
}