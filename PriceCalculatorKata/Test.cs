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
            UserInterface.AddUPCDiscount(12345, 0.07m);
            UserInterface.SetBeforeTaxDiscount(false);



            Product product1 = new()
            {
                Name = "The Little Prince",
                UPC = 12345,
                Price = 20.25m
            };
            UserInterface.HasPackagingCosts(true);
            UserInterface.HasTransportCosts(true);
            UserInterface.SetPackagingCosts(product1); 
            UserInterface.SetTransportCosts(product1);
            // I think it's wrong to send product1, but how to convert format from 1% to 1.2, I need product.price

            Print.PrintAllInfo(product1);


        }
    }

}

