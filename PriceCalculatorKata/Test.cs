using System;
namespace PriceCalculatorKata
{
    class Test
    {
        public static void Main()
        {
            UserInterface.SetTaxByCustomer();

            Product product1 = new()
            {
                Name = "The Little Prince",
                UPC = 12345,
                Price = 20.25m
            };
            Print.PrintProductInfo(product1);
            Print.PrintBasePrice(product1);
            Print.PrintPriceWithTax(product1);


        }
    }

}

