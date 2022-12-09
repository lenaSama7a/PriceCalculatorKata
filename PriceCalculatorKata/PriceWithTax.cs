using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public class PriceWithTax
    {

        public static decimal TaxAmount(Product product)
        {
            return Math.Round((product.Price * Tax.TaxPercentage),2);
        }

    }
}
