using CreationalDesignPatterns.AbstractFactory.Models;
using CreationalDesignPatterns.AbstractFactory.Models2;

namespace CreationalDesignPatterns.AbstractFactory;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Abstract Factory");
        //IYemekFactory factory = new TurkMutfagiFactory();
        //IAnaYemek anaYemek = factory.YemekHazirla();
        //anaYemek.Hazirla();

        //ISalata salata = factory.SalataHazirla();
        //salata.Hazirla();

        IMobilyaFactory factory = new ModernMobilyaFactory();
        IKoltuk koltuk = factory.KoltukOlustur();
        koltuk.BilgiVer();

        IMasa masa = factory.MasaOlustur();
        masa.BilgiVer();

        Console.ReadLine();
    }
}