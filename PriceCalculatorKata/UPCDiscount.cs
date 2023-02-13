using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public class UPCDiscount
    {
        public Dictionary<int, decimal>? UPCDiscountList = new();
        public bool BeforeTax = false;

        public decimal UPCDiscountPercentage(Product product, AllDiscounts allDiscounts)
        {
            if (allDiscounts.upcDiscount.HasUPCDiscount(product)) 
                return allDiscounts.upcDiscount.UPCDiscountList[product.UPC];
            return 0;
        }
        public bool HasUPCDiscount(Product product)
        {
            bool hasUPCDiscount = UPCDiscountList.ContainsKey(product.UPC);
            return hasUPCDiscount;
        }

    }
}
