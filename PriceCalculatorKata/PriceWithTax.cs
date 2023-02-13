using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public class PriceWithTax
    {
        public decimal TaxAmount(Product product, AllDiscounts allDiscounts, Tax tax)
        {
            if (allDiscounts.upcDiscount.BeforeTax)
            {
                return Math.Round((allDiscounts.PriceWithUPCDiscount.PriceAfterUPCDiscount(product, allDiscounts) * tax.TaxPercentage), Round.NumsOfFractionalDigits);
            }
            else
            return Math.Round((product.Price * tax.TaxPercentage),2);
        }
    }
}
