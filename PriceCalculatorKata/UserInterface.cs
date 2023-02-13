using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public class UserInterface
    {
        Print print = new();
        public void SetTaxByCustomer(Tax tax)
        {
            print.AskCustomerAboutTax();
            tax.TaxPercentage = Convert.ToDecimal(Console.ReadLine());
        }
        public void SetHasDiscount(bool hasDiscount, AllDiscounts allDiscounts)
        {

            allDiscounts.discount.HasDiscount = hasDiscount;
        }
        public void SetDiscountByCustomer(AllDiscounts allDiscounts)
        {
            if(allDiscounts.discount.HasDiscount == true)
            {
                print.AskCustomerAboutDiscount();
                allDiscounts.discount.DiscountPercentage = Convert.ToDecimal(Console.ReadLine());
            }
            else
            {
                allDiscounts.discount.DiscountPercentage = 0;
            }

        }
        public void AddUPCDiscount(int UPC, decimal discountPercentage, AllDiscounts allDiscounts)
        {

            allDiscounts.upcDiscount.UPCDiscountList.Add(UPC, discountPercentage);
        }

        public void SetBeforeTaxDiscount(bool beforeTax, AllDiscounts allDiscounts)
        {
            allDiscounts.upcDiscount.BeforeTax = beforeTax;
        }

        public void HasPackagingCosts(bool hasPackagingCosts, PackagingCosts packagingCosts)
        {
            packagingCosts.HasPackagingCost = hasPackagingCosts;
        }

        public void HasTransportCosts(bool hasTransportCosts, TransportCosts transportCosts)
        {
            transportCosts.HasTransportCost = hasTransportCosts;
        }

        public void SetPackagingCosts(Product prod, PackagingCosts packagingCosts)
        {
            if (packagingCosts.HasPackagingCost)
            {
                print.AskCustomerAboutPackagingCosts();
                String input = Console.ReadLine();
                packagingCosts.Amount = FixInputFormat.InputToAmountFormatting(prod, input);

            }
        }

        public void SetTransportCosts(Product prod, TransportCosts transportCosts)
        {
            if (transportCosts.HasTransportCost)
            {
                print.AskCustomerAboutTransportCosts();
                String input = Console.ReadLine();

                transportCosts.Amount = FixInputFormat.InputToAmountFormatting(prod, input);
            }
        }

        public void SetDiscountType(string discountType, AllDiscounts allDiscounts)
        {
            allDiscounts.discount.DiscountType = discountType;
        }

        public void HasCap(bool hasCap, Cap cap)
        {
            cap.HasCap = hasCap;
        }
        public void SetCap(Product prod, Cap cap)
        {
            if (cap.HasCap)
            {
                print.AskCustomerAboutCapAmount();
                String input = Console.ReadLine();
                cap.CapAmount = FixInputFormat.InputToAmountFormatting(prod, input);
            }
        }

        public void SetCurrency(Currency currency)
        {
            print.AskCustomerAboutCurrency();
            currency.currencyISOCode = Console.ReadLine();
        }
    }
}
