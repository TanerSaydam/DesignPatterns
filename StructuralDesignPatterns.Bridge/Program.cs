using StructuralDesignPatterns.Bridge.Bridge1;

namespace StructuralDesignPatterns.Bridge;

internal class Program
{
    static void Main(string[] args)
    {
        //Paypal
        IOdemeIslemi paypal = new Paypal("kullaniciAdi", "parola");
        OdemeIslemi odemeIslemi1 = new(paypal);
        odemeIslemi1.Yap(500);

        //Stripe
        IOdemeIslemi stripe = new Stripe("apiKey");
        OdemeIslemi odemeIslemi2 = new(stripe);
        odemeIslemi2.Yap(500);

        Console.WriteLine("Hello, World!");
    }
}