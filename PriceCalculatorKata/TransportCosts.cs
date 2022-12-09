using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public class TransportCosts
    {
        public static decimal Amount { get; set; } = 0;
        public static bool HasTransportCost { get; set; }

        public static void Description()
        {
            if(HasTransportCost)
            Console.WriteLine("Transport Costs has: $ " + Amount);
        }
    }
}
