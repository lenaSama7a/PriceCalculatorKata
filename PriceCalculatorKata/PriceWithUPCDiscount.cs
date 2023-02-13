using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public class PriceWithUPCDiscount
    {

        public decimal DiscountAmount(Product product, AllDiscounts allDiscounts)
        {
            if (allDiscounts.upcDiscount.HasUPCDiscount(product))
            {
                if (allDiscounts.discount.DiscountType.Equals("Additive"))
                {
                    return Math.Round(product.Price * allDiscounts.upcDiscount.UPCDiscountPercentage(product, allDiscounts), Round.NumsOfFractionalDigits);

                }
                else if (allDiscounts.discount.DiscountType.Equals("Multiplicative"))
                {
                    return Math.Round(allDiscounts.priceWithDiscount.PriceAfterDiscount(product, allDiscounts) * allDiscounts.upcDiscount.UPCDiscountPercentage(product ,allDiscounts), Round.NumsOfFractionalDigits);
                }
                else
                    return 0;
            }   
            else
                return 0;
        }

        public decimal PriceAfterUPCDiscount(Product product, AllDiscounts allDiscounts)
        { 
           return Math.Round(product.Price - DiscountAmount(product, allDiscounts),Round.NumsOfFractionalDigits);
        }
    }
}
