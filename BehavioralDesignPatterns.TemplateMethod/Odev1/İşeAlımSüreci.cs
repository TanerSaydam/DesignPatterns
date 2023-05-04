namespace BehavioralDesignPatterns.TemplateMethod.Odev1;

public abstract class İşeAlımSüreci
{
    public void İşBaşvurusuİşle()
    {
        BaşvuruAl();
        BaşvuruDeğerlendir();
        DepartmanaÖzelMülakatYap();
        İşTeklifiSun();
    }

    protected abstract void DepartmanaÖzelMülakatYap();

    private void BaşvuruAl()
    {
        Console.WriteLine("İş başvurusu alınıyor...");
    }

    private void BaşvuruDeğerlendir()
    {
        Console.WriteLine("İş başvurusu değerlendiriliyor...");
    }

    private void İşTeklifiSun()
    {
        Console.WriteLine("İş teklifi sunuluyor...");
    }
}

public class YazılımGeliştirmeAlımı : İşeAlımSüreci
{
    protected override void DepartmanaÖzelMülakatYap()
    {
        Console.WriteLine("Yazılım gelişltirme departmanına özel mülakat gerçekleştiriliyor...");
    }
}

public class PazarlamaAlımı : İşeAlımSüreci
{
    protected override void DepartmanaÖzelMülakatYap()
    {
        Console.WriteLine("Pazarlama departmanına özel mülakat gerçekleştiriliyor...");
    }
}
