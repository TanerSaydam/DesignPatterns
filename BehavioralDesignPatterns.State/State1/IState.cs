namespace BehavioralDesignPatterns.State.State1;

public interface IState
{
    void Handle(Context context);
}

public class Context
{
    private IState _state;

    public Context(IState state)
    {
        _state = state;
    }

    public IState State
    {
        get { return _state;}
        set
        {
            _state = value;
            Console.WriteLine($"Durum değiştirildi. {_state.GetType().Name}");
        }
    }

    public void Request()
    {
        _state.Handle(this);
    }
}

public class ConcreteStateA : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("ConcreteStateA tarafından işleniyor.");
        context.State = new ConcreteStateB();
    }
}

public class ConcreteStateB : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("ConcreteStateB tarafından işleniyor.");
        context.State = new ConcreteStateA();
    }
}
