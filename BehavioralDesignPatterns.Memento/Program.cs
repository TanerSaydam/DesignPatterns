using BehavioralDesignPatterns.Memento.Memento1;

namespace BehavioralDesignPatterns.Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Originator originator = new();
            CareTaker taker = new();

            originator.SetState("Aktif");
            taker.Save(originator);

            originator.SetState("Pasif");
            taker.Undo(originator);
        }
    }
}