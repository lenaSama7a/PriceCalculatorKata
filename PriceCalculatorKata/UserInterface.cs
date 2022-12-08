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
            Print.AskCustomerAboutTax();
            Tax.TaxPercentage = Convert.ToDecimal(Console.ReadLine());
        }

        public static void SetDiscountByCustomer()
        {
            Print.AskCustomerAboutDiscount();
            Discount.DiscountPercentage = Convert.ToDecimal(Console.ReadLine());
        }
    }
}
