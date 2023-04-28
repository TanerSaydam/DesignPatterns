namespace StructuralDesignPatterns.Composite.Composite2;

public abstract class Calisan
{
    public abstract void Print();
    public virtual void Add(Calisan calisan)
    {
        throw new NotImplementedException();
    }

    public virtual void Remove(Calisan calisan)
    {
        throw new NotImplementedException();
    }
}

public class Personel : Calisan
{
    private readonly string _name;
    private readonly string _profession;

    public Personel(string name, string profession)
    {
        _name = name;
        _profession = profession;
    }

    public override void Print()
    {
        Console.WriteLine($"{_name} - {_profession}");
    }
}

public class Yonetici : Calisan
{
    private readonly List<Calisan> _calisanlar = new List<Calisan>();
    private readonly string _name;
    private readonly string _profession;
    public Yonetici(string name, string profession)
    {
        _name = name;
        _profession = profession;
    }   

    public override void Print()
    {
        Console.WriteLine($"{_name} - {_profession}");
        foreach (var calisan in _calisanlar)
        {
            calisan.Print();
        }
    }

    public override void Add(Calisan calisan)
    {
        _calisanlar.Add(calisan);
    }

    public override void Remove(Calisan calisan)
    {
        _calisanlar.Remove(calisan);
    }
}
