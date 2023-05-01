namespace BehavioralDesignPatterns.Memento.Memento1;

public class Memento
{
    private readonly string _state;

    public Memento(string state)
    {
        _state = state;
    }

    public string GetState()
    {
        return _state;
    }
}

public class Originator
{
    private string _state; //aktif //pasif

    public void SetState(string state)
    {
        _state = state;
        Console.WriteLine($"Durum: {state}");
    }

    public Memento SaveState()
    {
        return new Memento( _state );
    }

    public void RestoreState( Memento memento )
    {
        _state = memento.GetState();
        Console.WriteLine($"Durum geri yüklendi: {_state}");
    }
}

public class CareTaker
{
    private Memento _memento;

    public void Save(Originator originator)
    {
        _memento = originator.SaveState();
    }

    public void Undo(Originator originator)
    {
        originator.RestoreState(_memento);
    }
}
