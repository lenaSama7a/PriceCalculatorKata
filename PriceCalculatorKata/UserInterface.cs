using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public class UserInterface
    {
        public static void SetTaxByCustomer()
        {
            Print.AskCustomerAboutTaxAmount();
            Tax.TaxAmount = Convert.ToDecimal(Console.ReadLine());
        }
    }
}
