using System.Collections.Generic;
using System.Collections.ObjectModel;
using Six.Scs.QA.Selenium.Model.ValueObjects;

namespace Six.Scs.QA.Selenium.Model.Factory
{
    public static class Services
    {
        public static ICollection<Service> Scs()
        {
            return new Collection<Service>
            {
                new Service
                {
                    Name = "SCS2.0",
                    Permission = "SCS2 Dummy"
                },
                new Service
                {
                    Name = "SCS",
                    Permission = "DPS-CustomerCare"
                },
                new Service
                {
                    Name = "SCS- acquirer",
                    Permission = "alle Acquirer"
                },
                new Service
                {
                    Name = "SCS- supplier",
                    Permission = "alle Supplier"
                },
                new Service
                {
                    Name = "SCS- ticket",
                    Permission = "Alle Tickets"
                }
            };
        }
    }
}