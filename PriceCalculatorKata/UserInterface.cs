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
        public static void SetHasDiscount(bool hasDiscount)
        {
            Discount.HasDiscount = hasDiscount;
        }
        public static void SetDiscountByCustomer()
        {
            if(Discount.HasDiscount == true)
            {
                Print.AskCustomerAboutDiscount();
                Discount.DiscountPercentage = Convert.ToDecimal(Console.ReadLine());
            }
            else
            {
                Discount.DiscountPercentage = 0;

            }

        }
        public static void AddUPCDiscount(int UPC, decimal discountPercentage)
        {

            UPCDiscount.UPCDiscountList.Add(UPC, discountPercentage);
        }
    }
}
