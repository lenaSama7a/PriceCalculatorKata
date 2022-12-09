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

        public static void SetBeforeTaxDiscount(bool beforeTax)
        {
            UPCDiscount.BeforeTax = beforeTax;
        }


        public static void HasPackagingCosts(bool hasPackagingCosts)
        {
            PackagingCosts.HasPackagingCost = hasPackagingCosts;
        }

        public static void HasTransportCosts(bool hasTransportCosts)
        {
            TransportCosts.HasTransportCost = hasTransportCosts;
        }

        public static void SetPackagingCosts(Product prod)
        {
            if (PackagingCosts.HasPackagingCost)
            {
                Print.AskCustomerAboutPackagingCosts();
                decimal amount;
                String input = Console.ReadLine();
                PackagingCosts.Amount = Costs.InputToAmountFormatting(prod, input);

            }


            // ICosts Packaging = new PackagingCosts();
            // Packaging.Amount = amount;
            //PackagingCosts.Amount = amount;
        }

        public static void SetTransportCosts(Product prod)
        {
            if (TransportCosts.HasTransportCost)
            {
                Print.AskCustomerAboutTransportCosts();
                decimal amount;
                String input = Console.ReadLine();

                TransportCosts.Amount = Costs.InputToAmountFormatting(prod, input);
            }
            
            
        }
    }
}
