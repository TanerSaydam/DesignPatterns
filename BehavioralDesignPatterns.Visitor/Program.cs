using BehavioralDesignPatterns.Visitor.Odev1;
using BehavioralDesignPatterns.Visitor.Visitor1;
using BehavioralDesignPatterns.Visitor.Visitor2;

namespace BehavioralDesignPatterns.Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //var elements = new IElement[] { new ConcreteElementA(), new ConcreteElementB() };
            //var visitor = new ConcreteVisitor();

            //foreach (var element in elements)
            //{
            //    element.Accept(visitor);
            //}

            //var products = new IProduct[] { new Book(100), new Electronic(200) };
            //var taxCalculator = new TaxCalculator();

            //foreach (var product in products)
            //{
            //    product.Accept(taxCalculator);
            //}

            var oduller = new IOdul[] { new AkademikOdul(), new SporOdulu() };
            var odulPuanHesaplayici = new OdulPuanHesaplayicisi();

            foreach (var odul in oduller)
            {
                odul.KabulEt(odulPuanHesaplayici);
            }

            Console.ReadKey();
        }
    }
}