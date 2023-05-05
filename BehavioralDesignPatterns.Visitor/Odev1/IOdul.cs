namespace BehavioralDesignPatterns.Visitor.Odev1;

public interface IOdul
{
    void KabulEt(IOdulPuanZiyaretcisi odulPuanZiyaretcisi);
}

public class AkademikOdul : IOdul
{
    public void KabulEt(IOdulPuanZiyaretcisi odulPuanZiyaretcisi)
    {
        odulPuanZiyaretcisi.ZiyaretEt(this);
    }
}

public class SporOdulu : IOdul
{
    public void KabulEt(IOdulPuanZiyaretcisi odulPuanZiyaretcisi)
    {
        odulPuanZiyaretcisi.ZiyaretEt(this);
    }
}

public interface IOdulPuanZiyaretcisi
{
    void ZiyaretEt(AkademikOdul akademikOdul);
    void ZiyaretEt(SporOdulu sporOdulu);
}

public class OdulPuanHesaplayicisi : IOdulPuanZiyaretcisi
{
    void IOdulPuanZiyaretcisi.ZiyaretEt(AkademikOdul akademikOdul)
    {
        int puan = 100;
        Console.WriteLine($"Akademik ödül için {puan} puan");
    }

    void IOdulPuanZiyaretcisi.ZiyaretEt(SporOdulu sporOdulu)
    {
        int puan = 75;
        Console.WriteLine($"Spor ödülü için {puan} puan");
    }
}
