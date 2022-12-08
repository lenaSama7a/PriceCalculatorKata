using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public class PriceWithTax
    {

        public static decimal CalculatePriceWithTax(Product product)
        {
            decimal price = product.Price;
            return Math.Round(price + (price * Tax.TaxAmount) , 2);
        }
    }
}
