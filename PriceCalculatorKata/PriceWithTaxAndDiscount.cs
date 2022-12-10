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
            
            return Math.Round(product.Price - UsingDiscountOrCap(product) + taxAmount + Costs.CalculateCostsAmount(), 2);
        }

        public static decimal TotalDiscount(Product product)
        {
            return (PriceWithDiscount.DiscountAmount(product) + PriceWithUPCDiscount.DiscountAmount(product));
        }

        public static decimal UsingDiscountOrCap(Product prod)
        {
            if (TotalDiscount(prod) >= Cap.CapAmount)
                return Cap.CapAmount;
            else
                return TotalDiscount(prod);
        }
    }
}
