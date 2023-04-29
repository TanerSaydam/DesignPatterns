using StructuralDesignPatterns.Decorator.Decorator1;
using StructuralDesignPatterns.Decorator.Decorator2;
using StructuralDesignPatterns.Decorator.Odev1;

namespace StructuralDesignPatterns.Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Beverage espresso = new Espresso();
            //Console.WriteLine($"{espresso.Description}: {espresso.Cost()}$");

            //Beverage espressoWithMilk = new Milk(espresso);
            //Console.WriteLine($"{espressoWithMilk.Description}: {espressoWithMilk.Cost()}$");
            //Console.WriteLine("Hello, World!");

            //UIComponent button = new Button();
            //button.Display();

            //UIComponent buttonWithBorder = new BorderDecoratoer(button);
            //buttonWithBorder.Display();

            IService basicService = new BasicService();
            IService authorizationService = new AuthorizationDecorator(basicService);

            authorizationService.Execute();
        }
    }
}