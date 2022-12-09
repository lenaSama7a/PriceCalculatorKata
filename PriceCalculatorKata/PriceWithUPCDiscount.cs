using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public class PriceWithUPCDiscount
    {

        public static decimal DiscountAmount(Product product)
        {
            if (UPCDiscount.HasUPCDiscount(product))
                return Math.Round(product.Price * UPCDiscount.UPCDiscountPercentage(product),2);
            return 0;
        }

        public static decimal PriceAfterUPCDiscount(Product product)
        {
           return Math.Round(product.Price - DiscountAmount(product),2);
        }
    }
}
