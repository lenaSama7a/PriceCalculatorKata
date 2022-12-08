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
            Console.Write($"Product price reported as ${product.Price} before tax");

        }
        public static void PrintPriceWithTax(Product product)
        {
            Console.WriteLine(" and $"+PriceWithTax.CalculatePriceWithTax(product)+ " after "+Tax.TaxAmount + " tax");

        }

        public static void AskCustomerAboutTaxAmount()
        {
            Console.WriteLine("Hello, How much is the tax imposed on the products?");
        }
    }
}
