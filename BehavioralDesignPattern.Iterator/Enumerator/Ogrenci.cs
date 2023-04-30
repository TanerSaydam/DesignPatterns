using System.Collections;

namespace BehavioralDesignPattern.Iterator.Enumerator;

public class Ogrenci
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
}

public class OgrenciKoleksiyonu : IEnumerable<Ogrenci>
{
    private List<Ogrenci> _ogrenciler = new();

    public void OgrenciEkle(Ogrenci ogrenci)
    {
        _ogrenciler.Add(ogrenci);
    }

    public IEnumerator<Ogrenci> GetEnumerator()
    {
        return _ogrenciler.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
