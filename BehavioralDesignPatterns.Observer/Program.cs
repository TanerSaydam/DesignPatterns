using BehavioralDesignPatterns.Observer.Observer1;

namespace BehavioralDesignPatterns.Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Observable observable = new();

            Observer1.Observer observer1 = new("Observer1");
            Observer1.Observer observer2 = new("Observer2");
            Observer1.Observer observer3 = new("Observer3");

            observable.Register(observer1);
            observable.Register(observer2);
            observable.Register(observer3);

            observable.SendMessage("Hello world!");
            

            //Console.WriteLine("Hello, World!");
        }
    }
}