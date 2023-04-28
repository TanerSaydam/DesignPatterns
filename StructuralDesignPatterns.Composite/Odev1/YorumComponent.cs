namespace StructuralDesignPatterns.Composite.Odev1;

public abstract class YorumComponent
{
    public abstract void Print(int seviye);
    public virtual void Add(YorumComponent component)
    {
        throw new NotImplementedException();
    }

    public virtual void Remove(YorumComponent component)
    {
        throw new NotImplementedException();
    }
}

public class Yorum : YorumComponent
{
    private readonly string _kullaniciAdi;
    private readonly string _metin;
    public Yorum(string kullaniciAdi, string metin)
    {
        _kullaniciAdi = kullaniciAdi;
        _metin = metin;
    }

    public override void Print(int seviye)
    {
        Console.WriteLine(new string('-', seviye * 2) + $"{_kullaniciAdi}: {_metin}");
    }
}

public class AltYorum: YorumComponent
{
    private readonly List<YorumComponent> _altYorumlar = new List<YorumComponent>();
    private readonly string _kullaniciAdi;
    private readonly string _metin;

    public AltYorum(string kullaniciAdi, string metin)
    {
        _kullaniciAdi = kullaniciAdi;
        _metin = metin;
    }

    public override void Print(int seviye)
    {
        Console.WriteLine(new string('-', seviye * 2) + $"{_kullaniciAdi}: {_metin}");
        foreach (var yorum in _altYorumlar)
        {
            yorum.Print(seviye + 1);
        }
    }

    public override void Add(YorumComponent component)
    {
        _altYorumlar.Add(component);
    }

    public override void Remove(YorumComponent component)
    {
        _altYorumlar.Remove(component);
    }
}
