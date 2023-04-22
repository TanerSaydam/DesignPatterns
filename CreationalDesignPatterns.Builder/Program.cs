using CreationalDesignPatterns.Builder.Models1;
using CreationalDesignPatterns.Builder.Models2;

namespace CreationalDesignPatterns.Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car familyCar = new CarDirector().BuildFamilyCar();
            Car sportCar = new CarDirector().BuildSportCar();

            Product product = new ProductDirector().BuildProduct("Mavi", "XL", "Nike");

            Console.WriteLine("Hello, World!");
        }
    }
}