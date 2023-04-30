namespace BehavioralDesignPatterns.Command.Command1;

public interface ICommand
{
    void Execute();
}

public class PrintHelloCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Merhaba!");
    }
}

public class PrintGoodByeCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Hoşça kal!");
    }
}

public class Invoker
{
    private ICommand _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void ExecuteCommand()
    {
        _command.Execute();
    }
}
