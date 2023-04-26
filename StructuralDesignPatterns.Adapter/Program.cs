using StructuralDesignPatterns.Adapter.Adapter1;

namespace StructuralDesignPatterns.Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Paypal
            IPayment payment1 = new PaypalPayment();
            ShoppingCart shoppingCart1 = new ShoppingCart(payment1);
            shoppingCart1.CheckOut(100);

            //Stripe
            IPayment payment2 = new StripPaymentAdapter();
            bool result = payment2.MakePayment(100);

            //PayU
            IPayment payment3 = new PayUPaymentAdapter();
            ShoppingCart shoppingCart3 = new(payment3);
            shoppingCart3.CheckOut(100);

            Console.WriteLine("Hello, World!");
        }
    }
}