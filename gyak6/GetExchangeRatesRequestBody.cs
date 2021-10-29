using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak6
{
    class GetExchangeRatesRequestBody
    {
        public string currencyNames { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
