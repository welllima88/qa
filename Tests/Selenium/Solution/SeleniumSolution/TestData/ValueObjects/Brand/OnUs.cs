﻿using System.Collections.Generic;

namespace Six.Scs.QA.TestData.ValueObjects.Brand
{
    public class OnUs : Brand
    {
        public string ContactlessCapabilities;
        public IEnumerable<Currency> Currencies;
        public bool Dcc;
        public Currency DccBaseCurrency;
    }
}