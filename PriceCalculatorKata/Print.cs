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
            Console.WriteLine($"Sample product: Book with name = {product.Name}," +
                $" UPC = {product.UPC}," +
                $" Price = ${product.Price}");

        }
        public static void PrintBasePrice(Product product)
        {
            Console.WriteLine($"Product price before: ${product.Price}");

        }
        public static void PrintPriceWithTaxAndDiscount(Product product)
        {
            Console.WriteLine($"Product price after Tax and discount ${PriceWithTaxAndDiscount.FinalPrice(product)}");

        }

        public static void PrintTaxPercentage(Product product)
        {
            Console.WriteLine("Tax= " + Tax.TaxPercentage );
        }
        public static void PrintDiscountPercentage(Product product)
        {
            Console.WriteLine("Discount = " + Discount.DiscountPercentage);
        }

        public static void PrintTaxAmount(Product product)
        {
            Console.WriteLine("Tax Amount = " + PriceWithTax.TaxAmount(product));
        }

        public static void PrintDiscountAmount(Product product)
        {
            Console.WriteLine("Discount Amount = " + PriceWithDiscount.DiscountAmount(product));
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
            PrintTaxAmount(prod);
            PrintDiscountAmount(prod);
            PrintBasePrice(prod);
            PrintPriceWithTaxAndDiscount(prod);

        }
        
    }
}
