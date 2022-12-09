using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public class PackagingCosts
    //: ICosts
    {
        //decimal ICosts.Amount { get; set; } 
        //public void Description()
        //{
        //    Console.WriteLine("Packaging Costs  "); // how to print amount here?
        //}
        public static decimal Amount { get; set; } = 0;
        public static bool HasPackagingCost { get; set; }

        public static void Description()
        {
            if(HasPackagingCost)
            Console.WriteLine("Packaging Costs has: $ " + Amount ); 
        }

        
    }
}
