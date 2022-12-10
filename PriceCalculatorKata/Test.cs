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

            UserInterface.SetDiscountType("Additive");
            //UserInterface.SetDiscountType("Multiplicative");

            
            Product product1 = new()
            {
                Name = "The Little Prince",
                UPC = 12345,
                Price = 20.25m
            };
            UserInterface.HasPackagingCosts(false);
            UserInterface.HasTransportCosts(false);
            UserInterface.SetPackagingCosts(product1); 
            UserInterface.SetTransportCosts(product1);

            UserInterface.HasCap(true);
            UserInterface.SetCap(product1); 
            // cap is applied to all product not just for product1, but I have to use product.price inside cap methods


            Print.PrintAllInfo(product1);


        }
    }

}

