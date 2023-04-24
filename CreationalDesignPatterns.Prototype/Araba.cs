namespace CreationalDesignPatterns.Prototype;

public class Araba : ICloneable
{
    public Araba(string marka, string model, int yil)
    {
        Marka = marka;
        Model = model;
        Yil = yil;
    }

    public string Marka { get; set; }
    public string Model { get; set; }
    public int Yil { get; set; }
    public object Clone()
    {
        return new Araba(Marka, Model, Yil);
    }
}

public class ArabaPrototip
{
    private Araba _araba;
    public ArabaPrototip(Araba araba)
    {
        _araba = araba;
    }

    public Araba Kopya()
    {
        return (Araba)_araba.Clone();
    }
}
