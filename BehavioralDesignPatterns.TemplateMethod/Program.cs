using BehavioralDesignPatterns.TemplateMethod.TemplateMethod1;

namespace BehavioralDesignPatterns.TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Icecek cay = new Cay();
            Icecek kahve = new Kahve();

            Console.WriteLine("Çay hazırlanıyor...");
            cay.IcecegiHazirla();

            Console.WriteLine("Kahve hazırlanıyor...");
            kahve.IcecegiHazirla();
        }
    }
}