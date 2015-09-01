namespace Six.Scs.Test.Model.Factory
{
    public class Contract
    {
        public static Model.Brand.Contract Create()
        {
            return new Model.Brand.Contract
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