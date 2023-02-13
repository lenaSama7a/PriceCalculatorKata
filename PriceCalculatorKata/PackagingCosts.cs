using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public class PackagingCosts
    {
        public decimal Amount { get; set; } = 0;
        public bool HasPackagingCost { get; set; }

        public void Description(Currency currency)
        {
            if(HasPackagingCost)
            Console.WriteLine($"Packaging Costs has: {Amount} {currency.currencyISOCode}" ); 
        }
    }
}
