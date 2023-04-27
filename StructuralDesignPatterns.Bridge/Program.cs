using StructuralDesignPatterns.Bridge.Brdige2;
using StructuralDesignPatterns.Bridge.Bridge1;

namespace StructuralDesignPatterns.Bridge;

internal class Program
{
    static void Main(string[] args)
    {
        ////Paypal
        //IOdemeIslemi paypal = new Paypal("kullaniciAdi", "parola");
        //OdemeIslemi odemeIslemi1 = new(paypal);
        //odemeIslemi1.Yap(500);

        ////Stripe
        //IOdemeIslemi stripe = new Stripe("apiKey");
        //OdemeIslemi odemeIslemi2 = new(stripe);
        //odemeIslemi2.Yap(500);

        IDevice tv = new Televizyon();
        UzakKontrol tvKontrol = new(tv);
        tvKontrol.TogglePower(); //TV'yi açar / kapatır
        tvKontrol.SesiArttir(); //Sesi aç

        IDevice radio = new Radio();
        UzakKontrol radioKontrol = new(radio);
        radioKontrol.TogglePower();
        radioKontrol.SesiArttir();

        Console.WriteLine("Hello, World!");
    }
}