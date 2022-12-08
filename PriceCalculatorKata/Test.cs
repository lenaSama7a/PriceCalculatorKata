using System;
namespace PriceCalculatorKata
{
    class Test
    {
        public static void Main()
        {
            UserInterface.SetTaxByCustomer();
            UserInterface.SetHasDiscount(true);
            UserInterface.SetDiscountByCustomer();

            Product product1 = new()
            {
                Name = "The Little Prince",
                UPC = 12345,
                Price = 20.25m
            };
            Print.PrintAllInfo(product1);


            UserInterface.SetHasDiscount(false);
            Product product2 = new()
            {
                Name = "The Little Prince",
                UPC = 12345,
                Price = 20.25m
            };
            Print.PrintAllInfo(product2);

        }
    }

}

