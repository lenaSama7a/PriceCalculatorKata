using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public class Discount
    {
        public bool HasDiscount { get; set; }
        public decimal DiscountPercentage { get; set; }
        public string? DiscountType { get; set; }

    }
}
