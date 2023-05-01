namespace BehavioralDesignPatterns.Mediator.Mediator2;

public interface IHavaTrafikKontrol
{
    void InisIzniIste(Ucak ucak);
    void InisiTamamladiginiBildir(Ucak ucak);
}

public abstract class Ucak
{
    public string Name { get; private set; }
    protected IHavaTrafikKontrol _atc;
    protected Ucak(string name, IHavaTrafikKontrol atc)
    {
        Name = name;
        _atc = atc;
    }

    public abstract void InisIzniIste();
    public abstract void InisiTamamladiginiBildir();
}

public class HavadakiUcak: Ucak
{
    public HavadakiUcak(string name, IHavaTrafikKontrol atc): base(name, atc)
    {
        
    }

    public override void InisiTamamladiginiBildir()
    {
        _atc.InisiTamamladiginiBildir(this);
    }

    public override void InisIzniIste()
    {
        _atc.InisIzniIste(this);
    }
}

public class HavaTrafikKontrol : IHavaTrafikKontrol
{
    private Queue<Ucak> _inisYapanUcaklar = new();
    
    public void InisiTamamladiginiBildir(Ucak ucak)
    {
        if(_inisYapanUcaklar.Peek() == ucak)
        {
            Console.WriteLine($"{ucak.Name} inişi tamamlandı!");
            _inisYapanUcaklar.Dequeue();

            if(_inisYapanUcaklar.Count > 0)
            {
                Ucak siradakiUcak = _inisYapanUcaklar.Peek();
                Console.WriteLine($"{siradakiUcak.Name} iniş iznin verildi!");
            }
        }
    }

    public void InisIzniIste(Ucak ucak)
    {
        if(_inisYapanUcaklar.Count() == 0)
        {
            Console.WriteLine($"{ucak.Name} iniş izni verildi!");
            _inisYapanUcaklar.Enqueue(ucak);
            return;
        }

        Console.WriteLine($"{ucak.Name} iniş için izin bekle!");
        _inisYapanUcaklar.Enqueue(ucak);
    }
}
