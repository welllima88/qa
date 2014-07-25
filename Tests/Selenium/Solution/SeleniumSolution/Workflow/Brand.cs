using System.Collections.Generic;
using Six.Scs.QA.TestData.ValueObjects.Brand;

namespace Six.Scs.QA.Workflow
{
    public class Brand
    {
        /// <summary>
        ///     Selects all brands in a the given List
        /// </summary>
        /// <param name="brands"></param>
        public static void Select(IEnumerable<TestData.ValueObjects.Brand.Brand> brands)
        {
            foreach (TestData.ValueObjects.Brand.Brand brand in brands)
            {
            }
        }

        /// <summary>
        ///     Selects the acquirer with all its brands
        /// </summary>
        /// <param name="acquirer"></param>
        public static void Select(Acquirer acquirer)
        {
        }

        /// <summary>
        ///     Selects all brands of all given contracts with its brands
        /// </summary>
        /// <param name="contracts"></param>
        public static void Select(IEnumerable<Contract> contracts)
        {
            foreach (Contract contract in contracts)
            {
                Select(contract.Brands);
            }
        }

        public static void Create(Contract contract)
        {
            // BrandCreate.
        }
    }
}