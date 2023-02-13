using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public class Costs
    {

        public decimal CalculateCostsAmount(PackagingCosts packagingCosts, TransportCosts transportCosts)
        {
            return Math.Round(packagingCosts.Amount + transportCosts.Amount, Round.NumsOfFractionalDigits);
        }

    }
}
