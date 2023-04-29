using StructuralDesignPatterns.Facade.Facade1;
using StructuralDesignPatterns.Facade.Facade2;
using StructuralDesignPatterns.Facade.Odev1;

namespace StructuralDesignPatterns.Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AltSistem1 altSistem1 = new();
            //AltSistem2 altSistem2 = new();
            //Facade1.Facade facade = new(altSistem1,altSistem2);
            //Console.WriteLine("Operasyon A");
            //Console.WriteLine(facade.OperasyonA());

            //Console.WriteLine("Operasyon B");
            //Console.WriteLine(facade.OperasyonB());

            //Console.WriteLine("Hello, World!");

            //Amplifier amplifier = new();
            //DvdPlayer dvdPlayer = new();
            //Projector projector = new();

            //HomeTheaterFacade homeTheaterFacade = new(amplifier, dvdPlayer, projector);
            //homeTheaterFacade.WatchMovie("Interstellar");
            //Console.WriteLine("\nFilm bitti. Sistem kapatılıyor...");
            //homeTheaterFacade.EndMovie();

            Kitap kitap1 = new()
            {
                Id = 1,
                Ad = "Clean Architecture",
                OduncDurumu = false
            };

            Uye uye1 = new()
            {
                Id = 1,
                Ad = "Taner",
                Soyad = "Saydam"
            };

            KutuphaneFacade kutuphane = new();
            kutuphane.KitapOduncAl(uye1, kitap1);

            OduncAlma oduncAlma = new()
            {
                Id = 1,
                Uye = uye1,
                Kitap = kitap1,
                AlisTarihi = DateTime.Now,
            };

            kutuphane.KitapTeslimEt(oduncAlma);
        }
    }
}