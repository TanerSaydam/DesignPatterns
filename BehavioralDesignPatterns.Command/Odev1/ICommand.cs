namespace BehavioralDesignPatterns.Command.Odev1;

public interface ICommand
{
    void Execute();
}

public class Espresso
{
    public void Prepare()
    {
        Console.WriteLine("Espresso hazırlanıyor...");
    }
}

public class Latte
{
    public void Prepare()
    {
        Console.WriteLine("Latte hazırlanıyor...");
    }
}

public class Cappuccino
{
    public void Prepare()
    {
        Console.WriteLine("Cappuccino hazırlanıyor...");
    }
}

public class EspressoCommand : ICommand
{
    private Espresso _espresso;

    public EspressoCommand(Espresso espresso)
    {
        _espresso = espresso;
    }

    public void Execute()
    {
        _espresso.Prepare();
        Console.WriteLine("Espresso siparişi hazır!");
    }
}

public class LatteCommand : ICommand
{
    private Latte _latte;

    public LatteCommand(Latte latte)
    {
        _latte = latte;
    }

    public void Execute()
    {
        _latte.Prepare();
        Console.WriteLine("Latte siparişi hazır!");
    }
}

public class CappuccinoCommand : ICommand
{
    private Cappuccino _capuccino;

    public CappuccinoCommand(Cappuccino capuccino)
    {
        _capuccino = capuccino;
    }

    public void Execute()
    {
        _capuccino.Prepare();
        Console.WriteLine("Cappuccino siparişi hazır!");
    }
}

public class Barista
{
    private ICommand _command;

    public void SetOrder(ICommand command)
    {
        _command = command;
    }

    public void PrepareOrder()
    {
        _command.Execute();
    }
}


