using StructuralDesignPatterns.FlyWeight.FlyWeight1;
using StructuralDesignPatterns.FlyWeight.FlyWeight2;
using StructuralDesignPatterns.FlyWeight.Odev1;

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

            //Forest forest = new();
            //forest.PlantTree(1, 1, "Çam");
            //forest.PlantTree(1, 2, "Çam");
            //forest.PlantTree(1, 3, "Çam");
            //forest.PlantTree(2, 1, "Meşe");
            //forest.PlantTree(2, 2, "Meşe");
            //forest.PlantTree(3, 1, "Kavak");

            //forest.Draw();

            TextFormatFactory factory = new();
            ITextFormat format1 = factory.GetFormat("Arial", 12, ConsoleColor.Blue);
            format1.AppyFormat("Merhaba Dünya!");

            ITextFormat format2 = factory.GetFormat("Arial", 12, ConsoleColor.Blue);
            format2.AppyFormat("Flyweight Pattern Örneği!");

            Console.WriteLine("Format1 ve format2 aynı mı?");
            Console.WriteLine(ReferenceEquals(format1,format2));
        }
    }
}