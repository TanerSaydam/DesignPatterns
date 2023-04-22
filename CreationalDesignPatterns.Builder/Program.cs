namespace CreationalDesignPatterns.Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car familyCar = new CarDirector().BuildFamilyCar();
            Car sportCar = new CarDirector().BuildSportCar();
            Console.WriteLine("Hello, World!");
        }
    }
}