using StructuralDesignPatterns.Decorator.Decorator1;

namespace StructuralDesignPatterns.Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            Console.WriteLine($"{espresso.Description}: {espresso.Cost()}$");

            Beverage espressoWithMilk = new Milk(espresso);
            Console.WriteLine($"{espressoWithMilk.Description}: {espressoWithMilk.Cost()}$");
            Console.WriteLine("Hello, World!");
        }
    }
}