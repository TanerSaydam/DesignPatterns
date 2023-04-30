using BehavioralDesignPatterns.Command.Command1;

namespace BehavioralDesignPatterns.Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Invoker invoker = new();

            ICommand helloCommand = new PrintHelloCommand();
            invoker.SetCommand(helloCommand);
            invoker.ExecuteCommand();

            ICommand goodByeCommand = new PrintGoodByeCommand();
            invoker.SetCommand(goodByeCommand);
            invoker.ExecuteCommand();
        }
    }
}