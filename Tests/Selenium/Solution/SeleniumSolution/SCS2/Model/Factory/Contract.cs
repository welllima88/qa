namespace Six.Scs.QA.Selenium.Model.Factory
{
    public class Contract
    {
        public static ValueObjects.Brand.Contract Create()
        {
            return new ValueObjects.Brand.Contract
            {
                Acquirer =
                {
                    Id = "",
                    Status = true,
                    NetAdress = "syr"
                },
                Brands = Brand.SixBrands()
            };
        }
    }
}