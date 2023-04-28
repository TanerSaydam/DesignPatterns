using StructuralDesignPatterns.Composite.Composite1;

namespace StructuralDesignPatterns.Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pizza = new MenuItem("Pizza", 12.99);
            var salate = new MenuItem("Salata", 8.99);
            var burger = new MenuItem("Burger", 10.99);

            var mainMenu = new Menu("Ana Menü");
            mainMenu.Add(pizza);
            mainMenu.Add(salate);
            mainMenu.Add(burger);

            var desserMenu = new Menu("Tatlı Menüsü");
            desserMenu.Add(new MenuItem("Dondurma", 5.99));
            desserMenu.Add(new MenuItem("Pasta", 6.99));


            mainMenu.Add(desserMenu);
            mainMenu.Print();

            //Console.WriteLine("Hello, World!");
        }
    }
}