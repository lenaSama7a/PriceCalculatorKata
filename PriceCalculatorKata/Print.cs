using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public class Print
    {
        public static void PrintProductInfo(Product product)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine($"Sample product: Book with name = {product.Name}," +
                $" UPC = {product.UPC}," +
                $" Price = ${product.Price}");

            Console.ForegroundColor = ConsoleColor.Gray;


        }
        public static void PrintBasePrice(Product product)
        {
            Console.WriteLine($"Product price before: ${product.Price}");

        }
        public static void PrintPriceWithTaxAndDiscount(Product product)
        {
            Console.WriteLine($"Product price after : ${PriceWithTaxAndDiscount.FinalPrice(product)}");

        }

        public static void PrintTaxPercentage(Product product)
        {
            Console.WriteLine("Tax= " + Tax.TaxPercentage);
        }
        public static void PrintDiscountPercentage(Product product)
        {
            if (Discount.HasDiscount)
                Console.WriteLine("Discount = " + Discount.DiscountPercentage);
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("no discount");
                Console.ForegroundColor = ConsoleColor.Gray;

            }
        }

        public static void PrintTaxAmount(Product product)
        {
            Console.WriteLine("Tax Amount = " + PriceWithTax.TaxAmount(product));
        }

        public static void PrintDiscountAmount(Product product)
        {
            if (Discount.HasDiscount)
                Console.WriteLine("Discount Amount = " + PriceWithDiscount.DiscountAmount(product) + " was deduced");

        }

        public static void AskCustomerAboutTax()
        {
            Console.WriteLine("Hello, How much is the tax imposed on the products?");
        }

        public static void AskCustomerAboutDiscount()
        {
            Console.WriteLine("How much is the discount?");
        }

        public static void PrintAllInfo(Product prod)
        {
            PrintProductInfo(prod);
            PrintTaxPercentage(prod);
            PrintDiscountPercentage(prod);
            PrintUPCDiscountPercentage(prod);

            PrintTaxAmount(prod);
            PrintDiscountAmount(prod);
            PrintUPCDiscountAmount(prod);

            PrintTotalCosts();

            PrintBasePrice(prod);
            PrintPriceWithTaxAndDiscount(prod);

        }

        public static void PrintUPCDiscountAmount(Product product)
        {
            if (UPCDiscount.HasUPCDiscount(product))
                Console.WriteLine("UPC Discount Amount: " + PriceWithUPCDiscount.DiscountAmount(product));
            if (UPCDiscount.BeforeTax)
            {
                Console.WriteLine(" Before Tax");
            }

        }

        public static void PrintUPCDiscountPercentage(Product product)
        {
            if (UPCDiscount.HasUPCDiscount(product))
                Console.WriteLine("UPC Discount Percentage: " + UPCDiscount.UPCDiscountPercentage(product));
            if (UPCDiscount.BeforeTax)
            {
                Console.WriteLine(" Before Tax");
            }
        }

        public static void AskCustomerAboutPackagingCosts()
        {
            Console.WriteLine("How much Packaging costs?");
        }

        public static void PrintPackagingCosts()
        {
            PackagingCosts.Description(); 
        }

        public static void AskCustomerAboutTransportCosts()
        {
            Console.WriteLine("How much Transport costs?");
        }

        public static void PrintTransportCosts()
        {
            TransportCosts.Description();
        }

        public static void PrintTotalCosts()
        {
            if(Costs.CalculateCostsAmount() > 0)
            {
                PrintTransportCosts();
                PrintPackagingCosts();
            }

        }
    }
}
