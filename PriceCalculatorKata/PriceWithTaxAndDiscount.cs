using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public class PriceWithTaxAndDiscount
    {
        public decimal FinalPrice(Product product,Tax tax, AllDiscounts allDiscounts, PriceWithTax priceWithTax, Costs costs, Cap cap, PackagingCosts pc, TransportCosts tc)
        {
            decimal discountAmount = allDiscounts.priceWithDiscount.DiscountAmount(product, allDiscounts);
            decimal taxAmount = priceWithTax.TaxAmount(product ,allDiscounts, tax);
            decimal UPCDiscountAmount = allDiscounts.PriceWithUPCDiscount.DiscountAmount(product ,allDiscounts);
            
            return Math.Round(product.Price - UsingDiscountOrCap(product, cap, allDiscounts) + taxAmount + costs.CalculateCostsAmount(pc, tc), Round.NumsOfFractionalDigits);
        }

        public decimal TotalDiscount(Product product, AllDiscounts allDiscounts)
        {
            return (allDiscounts.priceWithDiscount.DiscountAmount(product, allDiscounts) + allDiscounts.PriceWithUPCDiscount.DiscountAmount(product, allDiscounts));
        }

        public decimal UsingDiscountOrCap(Product prod, Cap cap, AllDiscounts allDiscounts)
        {
            if (cap.HasCap)
            {
                if (TotalDiscount(prod, allDiscounts) >= cap.CapAmount)
                    return cap.CapAmount;
                else
                    return TotalDiscount(prod, allDiscounts);

            }
            else
                return TotalDiscount(prod, allDiscounts);


        }
    }
}
