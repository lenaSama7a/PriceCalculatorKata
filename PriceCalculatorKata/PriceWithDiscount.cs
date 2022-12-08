﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public class PriceWithDiscount
    {
        public static decimal DiscountAmount(Product product)
        {
            return Discount.HasDiscount ? Math.Round((product.Price * Discount.DiscountPercentage), 2) : 0;
        }

        public static decimal PriceAfterDiscount(Product product)
        {
            decimal price = product.Price;
            return Math.Round(price - DiscountAmount(product), 2);
        }
    }
}
