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
                String input = Console.ReadLine();
                PackagingCosts.Amount = FixInputFormat.InputToAmountFormatting(prod, input);

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
                String input = Console.ReadLine();

                TransportCosts.Amount = FixInputFormat.InputToAmountFormatting(prod, input);
            }
        }

        public static void SetDiscountType(string discountType)
        {
            Discount.DiscountType = discountType;
        }

        public static void HasCap(bool hasCap)
        {
            Cap.HasCap = hasCap;
        }
        public static void SetCap(Product prod)
        {
            if (Cap.HasCap)
            {
                Print.AskCustomerAboutCapAmount();
                String input = Console.ReadLine();
                Cap.CapAmount = FixInputFormat.InputToAmountFormatting(prod, input);
            }
        }
    }
}
