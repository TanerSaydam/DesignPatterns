using BehavioralDesignPatterns.Strategy.Strategy1;

namespace BehavioralDesignPatterns.Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Shape shape = new(new DrawCircle());
            shape.Draw();

            shape.SetDrawStrategy(new DrawRectangle());
            shape.Draw();

            shape.SetDrawStrategy(new DrawTriangle());
            shape.Draw();           
        }
    }
}