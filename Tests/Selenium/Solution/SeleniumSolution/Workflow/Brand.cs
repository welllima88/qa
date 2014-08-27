using System.Collections.Generic;
using Six.Scs.QA.Selenium.Brand;
using Six.Scs.QA.TestData.ValueObjects.Brand;

namespace Six.Scs.QA.Workflow
{
    public class Brand
    {
        /// <summary>
        ///     Selects the acquirer with all its brands
        /// </summary>
        /// <param name="acquirer"></param>
        public static void Select(Acquirer acquirer)
        {
            Selection.Select(acquirer.Id, Selection.Acquirer);
        }

        /// <summary>
        ///     Selects all brands of all given contracts with its brands
        /// </summary>
        /// <param name="contracts"></param>
        public static void Select(IEnumerable<Contract> contracts)
        {
            foreach (Contract contract in contracts)
            {
                Selection.Open(contract.Acquirer.Id);
                foreach (TestData.ValueObjects.Brand.Brand brand in contract.Brands)
                {
                    Selection.Select(brand.Id);
                }
            }
        }

        public static void Create(Contract contract)
        {
            // BrandCreate.
        }
    }
}