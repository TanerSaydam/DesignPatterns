using StructuralDesignPatterns.Composite.Composite1;
using StructuralDesignPatterns.Composite.Composite2;
using StructuralDesignPatterns.Composite.Odev1;

namespace StructuralDesignPatterns.Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var pizza = new MenuItem("Pizza", 12.99);
            //var salate = new MenuItem("Salata", 8.99);
            //var burger = new MenuItem("Burger", 10.99);

            //var mainMenu = new Menu("Ana Menü");
            //mainMenu.Add(pizza);
            //mainMenu.Add(salate);
            //mainMenu.Add(burger);

            //var desserMenu = new Menu("Tatlı Menüsü");
            //desserMenu.Add(new MenuItem("Dondurma", 5.99));
            //desserMenu.Add(new MenuItem("Pasta", 6.99));


            //mainMenu.Add(desserMenu);
            //mainMenu.Print();

            //Console.WriteLine("Hello, World!");


            //var personel1 = new Personel("Ali", "Muhasebe");
            //var personel2 = new Personel("Ayşe", "Satış");

            //var yonetici1 = new Yonetici("Mehmet", "Muhasebe Yöneticisi");
            //yonetici1.Add(personel1);

            //var yonetici2 = new Yonetici("Fatma", "Satış Yöneticisi");
            //yonetici2.Add(personel2);

            //var genelMudur = new Yonetici("Osman", "Genel Müdür");
            //genelMudur.Add(yonetici1);
            //genelMudur.Add(yonetici2);

            //genelMudur.Print();

            var yorum1 = new AltYorum("Ahmet", "İlginç bir konu");
            var yorum2 = new AltYorum("Mehmet", "Ahmet'e katılıyorum");

            yorum1.Add(yorum2);

            var yorum3 = new AltYorum("Selda", "Mehmet'e katılıyorum");
            yorum2.Add(yorum3);

            yorum1.Print(0);

        }
    }
}