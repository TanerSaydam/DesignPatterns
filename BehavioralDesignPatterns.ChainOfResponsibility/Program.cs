using BehavioralDesignPatterns.ChainOfResponsibility.ChainOfResponsibility1;

namespace BehavioralDesignPatterns.ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sales sale1 = new(150);
            Sales sale2 = new(250);

            DiscountHandler handler1 = new FivePercentDiscountHandler();
            DiscountHandler handler2 = new TenPercentDiscountHandler();

            handler1.SetNextHandler(handler2);

            handler1.ApplyDiscount(sale1);
            handler1.ApplyDiscount(sale2);

            Console.WriteLine($"Sale 1 Amount: {sale1.Amount} \nDiscount: {sale1.Discount} \nFinal Amount: {sale1.FinalDiscount}");
            Console.WriteLine($"Sale 2 Amount: {sale2.Amount} \nDiscount: {sale2.Discount} \nFinal Amount: {sale2.FinalDiscount}");

        }
    }
}