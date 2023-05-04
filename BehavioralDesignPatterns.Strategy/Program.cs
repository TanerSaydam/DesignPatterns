using BehavioralDesignPatterns.Strategy.Strategy1;
using BehavioralDesignPatterns.Strategy.Strategy2;

namespace BehavioralDesignPatterns.Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Shape shape = new(new DrawCircle());
            //shape.Draw();

            //shape.SetDrawStrategy(new DrawRectangle());
            //shape.Draw();

            //shape.SetDrawStrategy(new DrawTriangle());
            //shape.Draw();           

            Checkout checkout = new(new CreditCartPayment());
            checkout.Pay(100);

            checkout.SetPaymentStrategy(new PaypalPayment());
            checkout.Pay(200);

            checkout.SetPaymentStrategy(new CryptoPayment());
            checkout.Pay(300);
        }
    }
}