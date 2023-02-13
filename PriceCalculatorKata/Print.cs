using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public class Print
    {
        public void PrintProductInfo(Product product, Currency currency)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine($"Sample product: Book with name = {product.Name}," +
                $" UPC = {product.UPC}," +
                $" Price = {currency.currencyISOCode} + {product.Price}");

            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public void PrintBasePrice(Product product, Currency currency)
        {
            Console.WriteLine($"Product price before: {product.Price} {currency.currencyISOCode}");
        }
        public void PrintPriceWithTaxAndDiscount(Product product, AllDiscounts allDiscounts, Tax tax, PriceWithTax priceWithTax, Costs costs, Cap cap, PackagingCosts pc, TransportCosts tc, Currency currency)
        {
            Console.WriteLine($"Product price after : {Math.Round(allDiscounts.PriceWithTaxAndDiscount.FinalPrice(product, tax, allDiscounts, priceWithTax, costs, cap, pc, tc), 2) } {currency.currencyISOCode}");
        }
        public void PrintTaxPercentage(Product product, Tax tax)
        {
            Console.WriteLine("Tax= " + tax.TaxPercentage);
        }
        public void PrintDiscountPercentage(Product product, AllDiscounts allDiscounts)
        {
            if (allDiscounts.discount.HasDiscount)
                Console.WriteLine("Discount = " + allDiscounts.discount.DiscountPercentage);
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("no discount");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        public void PrintTaxAmount(Product product, PriceWithTax priceWithTax, AllDiscounts allDiscounts, Tax tax, Currency currency)
        {
            Console.WriteLine($"Tax Amount = {priceWithTax.TaxAmount(product, allDiscounts, tax)} {currency.currencyISOCode}");
        }

        public void PrintDiscountAmount(Product product, AllDiscounts allDiscounts, Currency currency)
        {
            if (allDiscounts.discount.HasDiscount)
                Console.WriteLine($"Discount Amount = {allDiscounts.priceWithDiscount.DiscountAmount(product, allDiscounts)} {currency.currencyISOCode} was deduced");
        }

        public void AskCustomerAboutTax()
        {
            Console.WriteLine("Hello, How much is the tax imposed on the products?");
        }

        public void AskCustomerAboutDiscount()
        {
            Console.WriteLine("How much is the discount?");
        }

        public void PrintAllInfo(Product prod, Tax tax, AllDiscounts allDiscounts, Costs costs, Cap cap,
            PriceWithTax priceWithTax, TransportCosts transportCosts, PackagingCosts packagingCosts, Currency currency)
        {
            PrintProductInfo(prod, currency);
            PrintTaxPercentage(prod, tax);
            PrintDiscountPercentage(prod, allDiscounts);
            PrintUPCDiscountPercentage(prod, allDiscounts);

            PrintTaxAmount(prod, priceWithTax, allDiscounts, tax, currency);
            PrintDiscountAmount(prod, allDiscounts, currency);
            PrintUPCDiscountAmount(prod, allDiscounts, currency);

            PrintTotalCosts(costs, transportCosts, packagingCosts, currency);
            PrintTotalDiscount(prod, allDiscounts, currency);
            Console.WriteLine("The final result:");
            PrintBasePrice(prod, currency);
            PrintPriceWithTaxAndDiscount(prod, allDiscounts, tax, priceWithTax, costs, cap, packagingCosts, transportCosts, currency);

        }

        public void PrintUPCDiscountAmount(Product product, AllDiscounts allDiscounts, Currency currency)
        {
            if (allDiscounts.upcDiscount.HasUPCDiscount(product))
                Console.WriteLine($"UPC Discount Amount: {allDiscounts.PriceWithUPCDiscount.DiscountAmount(product, allDiscounts)} {currency.currencyISOCode} ");
            if (allDiscounts.upcDiscount.BeforeTax)
            {
                Console.WriteLine(" Before Tax");
            }
        }

        public void PrintUPCDiscountPercentage(Product product, AllDiscounts allDiscounts)
        {
            if (allDiscounts.upcDiscount.HasUPCDiscount(product))
                Console.WriteLine("UPC Discount Percentage: " + allDiscounts.upcDiscount.UPCDiscountPercentage(product, allDiscounts));
            if (allDiscounts.upcDiscount.BeforeTax)
            {
                Console.WriteLine(" Before Tax");
            }
        }

        public void AskCustomerAboutPackagingCosts()
        {
            Console.WriteLine("How much Packaging costs?");
        }

        public void PrintPackagingCosts(PackagingCosts packagingCosts, Currency currency)
        {
            packagingCosts.Description(currency); 
        }

        public void AskCustomerAboutTransportCosts()
        {
            Console.WriteLine("How much Transport costs?");
        }

        public void PrintTransportCosts(TransportCosts transportCosts, Currency currency)
        {
            transportCosts.Description(currency);
        }

        public void PrintTotalCosts(Costs costs, TransportCosts transportCosts, PackagingCosts packagingCosts, Currency currency)
        {
            if(costs.CalculateCostsAmount(packagingCosts, transportCosts) > 0)
            {
                PrintTransportCosts(transportCosts, currency);
                PrintPackagingCosts(packagingCosts, currency);
            }

        }
        public void PrintTotalDiscount(Product prod, AllDiscounts allDiscounts, Currency currency)
        {
            Console.WriteLine($"Total Discount: {allDiscounts.PriceWithTaxAndDiscount.TotalDiscount(prod, allDiscounts)} {currency.currencyISOCode} ");
        }

        public void AskCustomerAboutCapAmount()
        {
            Console.WriteLine("How much cap amount? ");        }

        public void AskCustomerAboutCurrency()
        {
            Console.WriteLine("What is the currency you would to use?");
        }
    }
}
