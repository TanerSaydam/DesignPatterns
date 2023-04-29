namespace StructuralDesignPatterns.Facade.Odev1;

public class Kitap
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public bool OduncDurumu { get; set; }
}

public class Uye
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
}

public class OduncAlma
{
    public int Id { get; set; }
    public Uye Uye { get; set; }
    public Kitap Kitap { get; set; }
    public DateTime AlisTarihi { get; set; }
    public DateTime? TeslimTarihi { get; set; }
    
}

public class KutuphaneFacade
{
    public void KitapOduncAl(Uye uye, Kitap kitap)
    {
        if (!kitap.OduncDurumu)
        {
            OduncAlma oduncAlma = new()
            {
                Uye = uye,
                Kitap = kitap,
                AlisTarihi = DateTime.Now
            };

            kitap.OduncDurumu = true;
            Console.WriteLine($"{uye.Ad} {uye.Soyad}, {kitap.Ad} adlı kitabı ödünç aldı.");
        }
        else
        {
            Console.WriteLine($"{kitap.Ad} adlı kitap şu anda başka bir üyemizde!");
        }
    }

    public void KitapTeslimEt(OduncAlma oduncAlma)
    {
        oduncAlma.Kitap.OduncDurumu = false;
        oduncAlma.TeslimTarihi = DateTime.Now;
        Console.WriteLine($"{oduncAlma.Uye.Ad} {oduncAlma.Uye.Soyad}, {oduncAlma.Kitap.Ad} adlı kitabı teslim etti.");
    }
}
