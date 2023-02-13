using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public class FixInputFormat
    {
        public static decimal InputToAmountFormatting(Product prod, String input)
        {
            decimal amount;
            char lastCharacter = input[input.Length - 1];
            if (lastCharacter == '%')
            {
                amount = Math.Round(prod.Price * (Convert.ToDecimal(input.Remove(input.Length - 1, 1)) / 100), Round.NumsOfFractionalDigits);
            }
            else
            {
                amount = Convert.ToDecimal(input);
            }
            return amount;
        }
    }

}
