using System.Collections.Generic;

namespace Six.Scs.Test.Model.ValueObjects.Brand
{
    public class Contract
    {
        public Acquirer Acquirer { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
    }
}