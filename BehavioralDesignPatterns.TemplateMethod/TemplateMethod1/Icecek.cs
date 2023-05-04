namespace BehavioralDesignPatterns.TemplateMethod.TemplateMethod1;

public abstract class Icecek
{
    public void IcecegiHazirla()
    {
        SuKaynat();
        Demle();
        BardagaDok();
        KatkiEkle();
    }

    protected abstract void Demle();
    protected abstract void KatkiEkle();
    private void SuKaynat()
    {
        Console.WriteLine("Su kaynatılıyor"); ;
    }

    private void BardagaDok()
    {
        Console.WriteLine("Bardağa dökülüyor");
    }
}


public class Cay : Icecek
{
    protected override void Demle()
    {
        Console.WriteLine("Çay demleniyor");
    }

    protected override void KatkiEkle()
    {
        Console.WriteLine("Limon ekleniyor");
    }
}

public class Kahve : Icecek
{
    protected override void Demle()
    {
        Console.WriteLine("Kahve süzgeçten geçiriliyor");
    }

    protected override void KatkiEkle()
    {
        Console.WriteLine("Şeker ve süt ekleniyor");
    }
}

