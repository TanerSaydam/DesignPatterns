using BehavioralDesignPatterns.Visitor.Visitor1;

namespace BehavioralDesignPatterns.Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            var elements = new IElement[] { new ConcreteElementA(), new ConcreteElementB() };
            var visitor = new ConcreteVisitor();

            foreach (var element in elements)
            {
                element.Accept(visitor);
            }

            Console.ReadKey();
        }
    }
}