using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public class UPCDiscount
    {
        public static Dictionary<int, decimal>? UPCDiscountList = new();
        public static bool BeforeTax = false;

        public static decimal UPCDiscountPercentage(Product product)
        {
            if (UPCDiscount.HasUPCDiscount(product))
                return UPCDiscount.UPCDiscountList[product.UPC];
            return 0;
        }
        public static bool HasUPCDiscount(Product product)
        {
            bool hasUPCDiscount = UPCDiscountList.ContainsKey(product.UPC);
            return hasUPCDiscount;
        }

    }
}
