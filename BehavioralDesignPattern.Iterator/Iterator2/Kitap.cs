using System.Collections;

namespace BehavioralDesignPattern.Iterator.Iterator2;

public class Kitap
{
    public string KitapAdi { get; set; }
    public string YazarAdi { get; set; }
}

public class KitapCollection : IEnumerable<Kitap>
{
    IList<Kitap> _items = new List<Kitap>();

    public void KitapEkle(Kitap item)
    {
        _items.Add(item);
    }
    public IEnumerator<Kitap> GetEnumerator()
    {
        return _items.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
