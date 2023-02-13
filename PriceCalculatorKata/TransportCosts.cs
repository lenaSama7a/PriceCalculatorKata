using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public class TransportCosts
    {
        public decimal Amount { get; set; } = 0;
        public bool HasTransportCost { get; set; }

        public void Description(Currency currency)
        {
            if(HasTransportCost)
            Console.WriteLine($"Transport Costs has: {Amount} {currency.currencyISOCode}" );
        }
    }
}
