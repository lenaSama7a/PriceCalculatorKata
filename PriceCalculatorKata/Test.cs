using System;
namespace PriceCalculatorKata
{
    class Test
    {
        public static void Main()
        {
            Cap cap = new();
            Tax tax = new();
            Costs costs = new();
            Print print = new();
            PriceWithTax priceWithTax = new();
            AllDiscounts allDiscounts = new();
            UserInterface userInterface = new();
            PackagingCosts packagingCosts = new();
            TransportCosts transportCosts = new();
            Currency currency = new();

            userInterface.SetCurrency(currency);
            userInterface.SetTaxByCustomer(tax);
            userInterface.SetHasDiscount(true, allDiscounts);
            userInterface.SetDiscountByCustomer(allDiscounts);
            userInterface.AddUPCDiscount(12345, 0.07m, allDiscounts);
            userInterface.SetBeforeTaxDiscount(true, allDiscounts);

            userInterface.SetDiscountType("Additive", allDiscounts);
            //userInterface.SetDiscountType("Multiplicative", allDiscounts);
            
            Product product1 = new()
            {
                Name = "The Little Prince",
                UPC = 12345,
                Price = 20.25m
            };

            userInterface.HasPackagingCosts(false, packagingCosts);
            userInterface.HasTransportCosts(true, transportCosts);
            userInterface.SetPackagingCosts(product1, packagingCosts);
            userInterface.SetTransportCosts(product1, transportCosts);

            userInterface.HasCap(false, cap);
            userInterface.SetCap(product1, cap); 

            print.PrintAllInfo(product1, tax, allDiscounts, costs, cap, priceWithTax, transportCosts, packagingCosts, currency);
        }
    }

}

