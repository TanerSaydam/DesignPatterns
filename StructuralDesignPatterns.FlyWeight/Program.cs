using StructuralDesignPatterns.FlyWeight.FlyWeight1;
using StructuralDesignPatterns.FlyWeight.FlyWeight2;

namespace StructuralDesignPatterns.FlyWeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ShapeFactory factory = new();
            //IShape line1 = factory.GetShape("line");
            //line1.Draw(0,0);

            //IShape line2 = factory.GetShape("line");
            //line2.Draw(1, 1);


            //Console.WriteLine("Line1 ve line2 aynı nesne mi?");
            //Console.WriteLine($"{ReferenceEquals(line1,line2)}");

            Forest forest = new();
            forest.PlantTree(1, 1, "Çam");
            forest.PlantTree(1, 2, "Çam");
            forest.PlantTree(1, 3, "Çam");
            forest.PlantTree(2, 1, "Meşe");
            forest.PlantTree(2, 2, "Meşe");
            forest.PlantTree(3, 1, "Kavak");

            forest.Draw();
        }
    }
}