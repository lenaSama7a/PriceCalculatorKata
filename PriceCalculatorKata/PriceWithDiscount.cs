using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public class PriceWithDiscount
    {
        public decimal DiscountAmount(Product product, AllDiscounts allDiscounts)
        {
            decimal discountAmount;
            if (allDiscounts.upcDiscount.BeforeTax)
            {
                discountAmount= allDiscounts.discount.HasDiscount ? Math.Round((allDiscounts.PriceWithUPCDiscount.PriceAfterUPCDiscount(product, allDiscounts) * allDiscounts.discount.DiscountPercentage), Round.NumsOfFractionalDigits) : 0;

            }
            else
            {
                discountAmount = allDiscounts.discount.HasDiscount ? Math.Round((product.Price * allDiscounts.discount.DiscountPercentage), Round.NumsOfFractionalDigits) : 0;

            }
            return discountAmount;
        }

        public decimal PriceAfterDiscount(Product product, AllDiscounts allDiscounts)
        {
            decimal price = product.Price;
            return Math.Round(price - DiscountAmount(product ,allDiscounts), Round.NumsOfFractionalDigits);
        }
    }
}
