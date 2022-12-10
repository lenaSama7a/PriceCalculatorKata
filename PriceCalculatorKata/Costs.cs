using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public class Costs
    {

        public static decimal CalculateCostsAmount()
        {
            return Math.Round( PackagingCosts.Amount + TransportCosts.Amount,2);
        }

    }
}
