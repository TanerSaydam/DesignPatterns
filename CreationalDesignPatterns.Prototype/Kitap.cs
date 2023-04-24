namespace CreationalDesignPatterns.Prototype;

public class Kitap : ICloneable
{
    public string Baslik { get; set; }
    public string Yazar { get; set; }
    public string Icerik { get; set; }
    public object Clone()
    {
        return this.MemberwiseClone();
    }
}

public class OnIizleme
{
    private Kitap _kitap;

    public OnIizleme(Kitap kitap)
    {
        _kitap = kitap;
    }

    public string OnIzlemeSonucu()
    {
        var kitapKopyasi = (Kitap)_kitap.Clone();

        var icerik = kitapKopyasi.Icerik;

        return icerik.Substring(0, Math.Min(icerik.Length, 100));
    }
}
