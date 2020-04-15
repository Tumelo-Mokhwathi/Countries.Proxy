using System;
using System.Collections.Generic;

namespace Country.Proxy.Models
{
    public partial class Countries
    {
        public string Id { get; set; }
        public string Abbreviation { get; set; }
        public string CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySymbol { get; set; }
        public string CountryName { get; set; }
    }
}
