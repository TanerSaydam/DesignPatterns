using BehavioralDesignPatterns.Command.Command1;
using BehavioralDesignPatterns.Command.Command2;

namespace BehavioralDesignPatterns.Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Invoker invoker = new();

            //ICommand helloCommand = new PrintHelloCommand();
            //invoker.SetCommand(helloCommand);
            //invoker.ExecuteCommand();

            //ICommand goodByeCommand = new PrintGoodByeCommand();
            //invoker.SetCommand(goodByeCommand);
            //invoker.ExecuteCommand();

            Light livingRoomLight = new();
            RemoteControl remoteControl = new();

            Command2.ICommand turnOnLight = new TurnOnLightCommand(livingRoomLight);
            remoteControl.SetCommand(turnOnLight);
            remoteControl.PressButton();

            Command2.ICommand turnOffLight = new TurnOffLightCommand(livingRoomLight);
            remoteControl.SetCommand(turnOffLight);
            remoteControl.PressButton();

        }
    }
}