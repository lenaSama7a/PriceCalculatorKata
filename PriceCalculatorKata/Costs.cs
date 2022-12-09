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
            return PackagingCosts.Amount + TransportCosts.Amount;
        }

        public static decimal InputToAmountFormatting(Product prod, String input)
        {
            decimal amount;
            char lastCharacter = input[input.Length - 1];
            if (lastCharacter == '%')
            {
                amount = prod.Price * (Convert.ToDecimal(input.Remove(input.Length - 1, 1)) / 100);
            }
            else
            {
                amount = Convert.ToDecimal(input);
            }
            return amount;
        }
    }
}
