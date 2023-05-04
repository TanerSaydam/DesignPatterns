namespace BehavioralDesignPatterns.State.State2;

public interface IATMState
{
    void InsertCart();
    void EjectCart();
    void EnterPin(int pin);
    void RequestCash(int amount);
}

public class NoCard : IATMState
{
    private readonly ATMMachine _atmMachine;

    public NoCard(ATMMachine atmMachine)
    {
        _atmMachine = atmMachine;
    }

    public void EjectCart()
    {
        Console.WriteLine("Katınızı takmadınız");
    }

    public void EnterPin(int pin)
    {
        Console.WriteLine("Önce kartınızı takınız");
    }

    public void InsertCart()
    {
        Console.WriteLine("Kartınız kabul edildi!");
        _atmMachine.SetATMState(_atmMachine.HasCard);
    }

    public void RequestCash(int amount)
    {
        Console.WriteLine("Önce kartınızı takınız");
    }
}

public class HasCard: IATMState
{
    private readonly ATMMachine _atmMachine;

    public HasCard(ATMMachine atmMachine)
    {
        _atmMachine = atmMachine;
    }

    public void EjectCart()
    {
        Console.WriteLine("Katınız geri verildi!");
        _atmMachine.SetATMState(_atmMachine.NoCard);
    }

    public void EnterPin(int pin)
    {
        if(pin == 1234)
        {
            Console.WriteLine("PIN Doğru");
            _atmMachine.SetATMState(_atmMachine.PinEntered);
        }
        else
        {
            Console.WriteLine("Yanlış PIN");
            EjectCart();
        }
    }

    public void InsertCart()
    {
        Console.WriteLine("Zaten ATM içinde bir kartınız var!");
    }

    public void RequestCash(int amount)
    {
        Console.WriteLine("Önce PIN numarasını girin!");
    }
}

public class PinEntered : IATMState
{
    private readonly ATMMachine _atmMachine;

    public PinEntered(ATMMachine atmMachine)
    {
        _atmMachine = atmMachine;
    }

    public void EjectCart()
    {
        Console.WriteLine("Kartını geri verildi.");
        _atmMachine.SetATMState(_atmMachine.NoCard);
    }

    public void EnterPin(int pin)
    {
        Console.WriteLine("PIN zaten girildi!");
    }

    public void InsertCart()
    {
        Console.WriteLine("Zaten takılı bir kartınız var!");
    }

    public void RequestCash(int amount)
    {
        if(amount > _atmMachine.CashInMachine)
        {
            Console.WriteLine("ATM'de yeterince para yok!");
            EjectCart();
        }
        else
        {
            Console.WriteLine($"Paranız: {amount}$");
            _atmMachine.CashInMachine -= amount;
            EjectCart();
        }
    }
}

public class ATMMachine
{
    public IATMState NoCard { get; private set; }
    public IATMState HasCard { get; private set; }
    public IATMState PinEntered { get; private set; }

    private IATMState _currentState;
    public int CashInMachine { get; set; }

    public ATMMachine()
    {
        NoCard = new NoCard(this);
        HasCard = new HasCard(this);
        PinEntered = new PinEntered(this);

        _currentState = NoCard;
        CashInMachine = 2000;
    }

    public void SetATMState(IATMState state)
    {
        _currentState = state;
    }

    public void InsertCard()
    {
        _currentState.InsertCart();
    }

    public void EjectCard()
    {
        _currentState.EjectCart();
    }

    public void EnterPin(int pin)
    {
        _currentState.EnterPin(pin);
    }

    public void RequestCash(int amount)
    {
        _currentState.RequestCash(amount);
    }
}
