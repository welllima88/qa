using System.Collections.Generic;
using System.Collections.ObjectModel;
using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.TestData.Factory
{
    public class Services
    {
        public static IEnumerable<Service> Scs()
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