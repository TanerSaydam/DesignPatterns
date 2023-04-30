using BehavioralDesignPattern.Iterator.Iterator2;

namespace BehavioralDesignPattern.Iterator;

internal class Program
{
    static void Main(string[] args)
    {
        //OgrenciKoleksiyonu ogrenciKoleksiyonu = new();
        //ogrenciKoleksiyonu.OgrenciEkle(new Ogrenci { Ad = "Taner", Soyad = "Saydam" });
        //ogrenciKoleksiyonu.OgrenciEkle(new Ogrenci { Ad = "Tugay", Soyad = "Saydam" });
        //ogrenciKoleksiyonu.OgrenciEkle(new Ogrenci { Ad = "Tahir", Soyad = "Saydam" });
        //ogrenciKoleksiyonu.OgrenciEkle(new Ogrenci { Ad = "Toprak", Soyad = "Saydam" });

        //IEnumerator ogrenciIterator = ogrenciKoleksiyonu.GetEnumerator();

        //current 
        //MoveNext
        //reset

        //while(ogrenciIterator.MoveNext())
        //{
        //    Ogrenci ogrenci = ogrenciIterator.Current as Ogrenci;
        //    Console.WriteLine($"{ogrenci.Ad} {ogrenci.Soyad}");
        //}

        //foreach (var ogrenci in ogrenciKoleksiyonu)
        //{
        //    Console.WriteLine($"{ogrenci.Ad} {ogrenci.Soyad}");
        //}
        //
        KitapCollection kitaps = new();
        kitaps.KitapEkle(new Kitap { KitapAdi = "Kitap 1", YazarAdi = "Yazar 1" });
        kitaps.KitapEkle(new Kitap { KitapAdi = "Kitap 2", YazarAdi = "Yazar 2" });
        kitaps.KitapEkle(new Kitap { KitapAdi = "Kitap 3", YazarAdi = "Yazar 3" });
        kitaps.KitapEkle(new Kitap { KitapAdi = "Kitap 4", YazarAdi = "Yazar 4" });

        foreach (var item in kitaps)
        {
            Console.WriteLine($"{item.KitapAdi} {item.YazarAdi}");
        }
    }
}