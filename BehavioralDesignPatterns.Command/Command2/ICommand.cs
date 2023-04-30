namespace BehavioralDesignPatterns.Command.Command2;

public interface ICommand
{
    void Execute();
}

public class Light
{
    public void TurnOn() =>
        Console.WriteLine("Işık açıldı!");

    public void TurnOff() =>
    Console.WriteLine("Işık kapatıldı!");
}

public class TurnOnLightCommand : ICommand
{
    private Light _light;

    public TurnOnLightCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOn();
    }
}

public class TurnOffLightCommand : ICommand
{
    private Light _light;

    public TurnOffLightCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOff();
    }
}

public class RemoteControl
{
    private ICommand _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void PressButton()
    {
        _command.Execute();
    }
}
