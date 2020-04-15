using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Country.Proxy.Models
{
    public class CountriesResult
    {

        public int code { get; }
        public Countries[] countries { get; set; } 
        public string source { get; }

        public CountriesResult()
        {
            code = 200;
            source = "countries.proxy.source"; 
        }

    }
}
