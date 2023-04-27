namespace StructuralDesignPatterns.Bridge.Bridge1;

public interface IOdemeIslemi
{
    bool OdemeYap(decimal tutar);
}

public class Paypal : IOdemeIslemi
{
    private string _kullaniciAdi;
    private string _parola;

    public Paypal(string parola, string kullaniciAdi)
    {
        _parola = parola;
        _kullaniciAdi = kullaniciAdi;
    }

    public bool OdemeYap(decimal tutar)
    {
        Console.WriteLine($"Paypal ile {tutar} ₺ tutarında ödeme yapıldı!");
        return true; 
    }
}

public class Stripe : IOdemeIslemi
{
    private string _apiAnahtari;

    public Stripe(string apiAnahtari)
    {
        _apiAnahtari = apiAnahtari;
    }

    public bool OdemeYap(decimal tutar)
    {
        Console.WriteLine($"Stripe ile {tutar} ₺ tutarında ödeme yapıldı!");
        return true;
    }
}

public class OdemeIslemi
{
    private IOdemeIslemi _odemeIslemi;

    public OdemeIslemi(IOdemeIslemi odemeIslemi)
    {
        _odemeIslemi = odemeIslemi;
    }

    public bool Yap(decimal tutar)
    {
        return _odemeIslemi.OdemeYap(tutar);
    }
}