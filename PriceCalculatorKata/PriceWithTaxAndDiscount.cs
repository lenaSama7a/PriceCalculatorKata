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
            decimal discountAmount = PriceWithDiscount.DiscountAmount(product);
            decimal taxAmount = PriceWithTax.TaxAmount(product);
            decimal UPCDiscountAmount = PriceWithUPCDiscount.DiscountAmount(product);
            
            return Math.Round(product.Price - discountAmount - UPCDiscountAmount + taxAmount + Costs.CalculateCostsAmount(), 2);
        }
    }
}
