using BehavioralDesignPatterns.Command.Command1;
using BehavioralDesignPatterns.Command.Command2;
using BehavioralDesignPatterns.Command.Odev1;

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

            //Light livingRoomLight = new();
            //RemoteControl remoteControl = new();

            //Command2.ICommand turnOnLight = new TurnOnLightCommand(livingRoomLight);
            //remoteControl.SetCommand(turnOnLight);
            //remoteControl.PressButton();

            //Command2.ICommand turnOffLight = new TurnOffLightCommand(livingRoomLight);
            //remoteControl.SetCommand(turnOffLight);
            //remoteControl.PressButton();

            Barista barista = new();
            Console.WriteLine("Kahve siparişi girin:\n 1. Espresso\n2. Latte\n3.Cappuccino");
            int coffeType = int.Parse(Console.ReadLine());

            switch (coffeType)
            {
                case 1:
                    Espresso espresso = new();
                    Odev1.ICommand espressoCommand = new EspressoCommand(espresso);
                    barista.SetOrder(espressoCommand);
                    break;
                case 2:
                    Latte latte = new();
                    Odev1.ICommand latteCommand = new LatteCommand(latte);
                    barista.SetOrder(latteCommand);
                    break;
                case 3:
                    Cappuccino cappuccino = new();
                    Odev1.ICommand cappuccinoCommand = new CappuccinoCommand(cappuccino);
                    barista.SetOrder(cappuccinoCommand);
                    break;
            }
            barista.PrepareOrder();

            Console.ReadLine();
        }
    }
}