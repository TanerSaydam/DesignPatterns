using BehavioralDesignPatterns.ChainOfResponsibility.ChainOfResponsibility1;
using BehavioralDesignPatterns.ChainOfResponsibility.Odev1;

namespace BehavioralDesignPatterns.ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sales sale1 = new(150);
            //Sales sale2 = new(250);

            //DiscountHandler handler1 = new FivePercentDiscountHandler();
            //DiscountHandler handler2 = new TenPercentDiscountHandler();

            //handler1.SetNextHandler(handler2);

            //handler1.ApplyDiscount(sale1);
            //handler1.ApplyDiscount(sale2);

            //Console.WriteLine($"Sale 1 Amount: {sale1.Amount} \nDiscount: {sale1.Discount} \nFinal Amount: {sale1.FinalDiscount}");
            //Console.WriteLine($"Sale 2 Amount: {sale2.Amount} \nDiscount: {sale2.Discount} \nFinal Amount: {sale2.FinalDiscount}");

            //Application application = new()
            //{
            //    Adi = "Taner Saydam",
            //    MezuniyetDerecesi = 3m,
            //    DilSeviyesi = 2,
            //    TecrubeYili = 0,
            //};

            //ApplicationHandler handler1 = new MezuniyetDerecesiHandler();
            //ApplicationHandler handler2 = new DilSeviyesiHandler();
            //ApplicationHandler handler3 = new TecrubeYiliHandler();

            //handler1.SetNextHandler(handler2);
            //handler2.SetNextHandler(handler3);

            //handler1.CheckUserForJob(application);

            //Console.WriteLine($"Application for {application.Adi} is {(application.KabulEdildiMi ? "accepted" : "rejected")}.");

            Order order = new("Taner Saydam", 300);

            Odev1.DiscountHandler bronzeHandler = new BronzeCustomerDiscountHandler();
            Odev1.DiscountHandler silverHandler = new SilverCustomerDiscountHandler();
            Odev1.DiscountHandler goldHandler = new GoldCustomerDiscountHandler();

            bronzeHandler.SetNextHandler(silverHandler);
            silverHandler.SetNextHandler(goldHandler);

            bronzeHandler.ApplyDiscount(order);

            Console.WriteLine($"Customer: {order.CustomerName}\nAmount: {order.Amount}$\nDiscount: {order.Discount}$\nTotal: {order.Total}$");

        }
    }
}