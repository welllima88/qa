using System.Collections.ObjectModel;

namespace Six.Scs.QA.Selenium.Extension.TestData.Factory
{
    public class ContractFactory
    {
        public static ContractData Create()
        {
            return new ContractData();
        }
    }

    public class ContractData
    {
        public AcquirerData Acquirer { get; set; }
        public Collection<BrandData> BrandList { get; set; }
    }

    public class BrandData
    {
    }

    public class AcquirerData
    {
    }
}