using PriceCalculatorKata;
using System;

public class AllDiscounts
{
    public Discount discount { get; set; } = new();
    public UPCDiscount upcDiscount = new();
    public PriceWithDiscount priceWithDiscount = new();
    public PriceWithUPCDiscount PriceWithUPCDiscount = new();
    public PriceWithTaxAndDiscount PriceWithTaxAndDiscount = new();
}
