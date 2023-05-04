using BehavioralDesignPatterns.State.State1;

namespace BehavioralDesignPatterns.State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            IState initialState = new ConcreteStateA();
            Context context = new(initialState);

            context.Request();
            context.Request();
            context.Request();

            Console.ReadKey();
        }
    }
}