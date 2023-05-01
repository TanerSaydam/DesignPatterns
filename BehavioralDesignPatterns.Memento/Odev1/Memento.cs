namespace BehavioralDesignPatterns.Memento.Odev1;

public class Memento
{
    public Memento(int health, int energy, int level)
    {
        Health = health;
        Energy = energy;
        Level = level;
    }

    public int Health { get;}
    public int Energy { get;}
    public int Level { get; }
}

public class Character
{
    public Character(int health, int energy, int level)
    {
        Health = health;
        Energy = energy;
        Level = level;
    }

    public int Health { get; set; }
    public int Energy { get; set; }
    public int Level { get; set; }

    public Memento Save()
    {
        return new Memento(Health, Energy, Level);
    }

    public void Restore(Memento memento)
    {
        Health = memento.Health;
        Energy = memento.Energy;
        Level = memento.Level;
    }
}

public class GameState
{
    private readonly Stack<Memento> _undoStack = new();

    public void Save(Character character)
    {
        _undoStack.Push(character.Save());
    }

    public void Undo(Character character)
    {
        if(_undoStack.Count > 0)
        {
            Memento memento = _undoStack.Pop();
            character.Restore(memento);
        }
    }
}
