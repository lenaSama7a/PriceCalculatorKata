using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public class PriceWithTaxAndDiscount
    {
        public static decimal FinalPrice(Product product)
        {
            decimal priceAfterDiscount = PriceWithDiscount.PriceAfterDiscount(product);
            decimal taxAmount = PriceWithTax.TaxAmount(product);
            return Math.Round(priceAfterDiscount + taxAmount, 2);
        }
    }
}
