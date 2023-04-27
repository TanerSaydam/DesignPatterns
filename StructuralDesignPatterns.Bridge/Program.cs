using StructuralDesignPatterns.Bridge.Brdige2;
using StructuralDesignPatterns.Bridge.Bridge1;
using StructuralDesignPatterns.Bridge.Odev1;

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

        //IDevice tv = new Televizyon();
        //UzakKontrol tvKontrol = new(tv);
        //tvKontrol.TogglePower(); //TV'yi açar / kapatır
        //tvKontrol.SesiArttir(); //Sesi aç

        //IDevice radio = new Radio();
        //UzakKontrol radioKontrol = new(radio);
        //radioKontrol.TogglePower();
        //radioKontrol.SesiArttir();

        IVehicleBrand toyota = new Toyota();
        IVehicleModel corolla = new Corolla();
        Vehicle vehicle1 = new(toyota, corolla);
        Console.WriteLine(vehicle1.GetVehicleInfo());


        IVehicleBrand bmw = new BMW();
        IVehicleModel x5 = new X5();
        Vehicle vehicle2 = new(bmw, x5);
        Console.WriteLine(vehicle2.GetVehicleInfo());
        Console.WriteLine("Hello, World!");
    }
}