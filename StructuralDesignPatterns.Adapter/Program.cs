using StructuralDesignPatterns.Adapter.Adapter1;
using StructuralDesignPatterns.Adapter.Adapter2;
using StructuralDesignPatterns.Adapter.Odev1;

namespace StructuralDesignPatterns.Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Paypal
            //IPayment payment1 = new PaypalPayment();
            //ShoppingCart shoppingCart1 = new ShoppingCart(payment1);
            //shoppingCart1.CheckOut(100);

            ////Stripe
            //IPayment payment2 = new StripPaymentAdapter();
            //bool result = payment2.MakePayment(100);

            ////PayU
            //IPayment payment3 = new PayUPaymentAdapter();
            //ShoppingCart shoppingCart3 = new(payment3);
            //shoppingCart3.CheckOut(100);

            ////MySql
            //IDatabase database1 = new MySqlDatabase();
            //database1.Connect();
            //database1.ExecuteQuery("Select * From Users");

            ////MSSql
            //IDatabase database2 = new SqlServerAdapter();
            //database2.Connect();
            //database2.ExecuteQuery("Select * From Users");

            //XML
            IFileConverter fileConverter1 = new XMLConvert();
            fileConverter1.Convert("Deneme");

            //JSON
            IFileConverter fileConverter2 = new JSONConvertAdapter();
            fileConverter2.Convert("Deneme");

            Console.WriteLine("Hello, World!");
        }
    }
}