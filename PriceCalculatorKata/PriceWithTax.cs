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
            if (UPCDiscount.BeforeTax)
            {
                return Math.Round((PriceWithUPCDiscount.PriceAfterUPCDiscount(product) * Tax.TaxPercentage), 2);
                
            }
            else
            return Math.Round((product.Price * Tax.TaxPercentage),2);
        }

    }
}
