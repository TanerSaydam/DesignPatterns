using BehavioralDesignPatterns.State.State1;
using BehavioralDesignPatterns.State.State2;

namespace BehavioralDesignPatterns.State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //IState initialState = new ConcreteStateA();
            //Context context = new(initialState);

            //context.Request();
            //context.Request();
            //context.Request();

            //Console.ReadKey();

            ATMMachine atmMachine = new();
            //atmMachine.InsertCard();
            atmMachine.EnterPin(1234);
            atmMachine.RequestCash(1500);
            atmMachine.EjectCard();
            Console.ReadKey();
        }
    }
}