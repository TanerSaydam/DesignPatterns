using StructuralDesignPatterns.Proxy.Proxy1;

namespace StructuralDesignPatterns.Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISubject proxy = new Proxy1.Proxy();
            proxy.Request();

            //Console.WriteLine("Hello, World!");
        }
    }
}