using CreationalDesignPatterns.Prototype.Odev1;
using System.Xml;

namespace CreationalDesignPatterns.Prototype;

internal class Program
{
    static void Main(string[] args)
    {
        //var araba = new Araba("Toyota", "Corolloa", 2022);
        //var prototip = new ArabaPrototip(araba);

        //var yeniAraba1 = prototip.Kopya();
        //var yeniAraba2 = prototip.Kopya();


        //var kitap = new Kitap { Baslik = "Sefiller", Yazar= "Victor Hugo", Icerik= "Sefiller (Fransızca: Les Misérables; Fransızca telaffuz: [le mizeʁabl(ə)]), Victor Hugo tarafından yazılan tarihi romandır. İlk olarak 1862'de yayınlandı. 19. yüzyılın en büyük eserlerinden biri olarak kabul gördü. İngilizce konuşulan ülkelerde başarısız çeviriler nedeniyle genellikle orijinal Fransız ismiyle anılır. Hikâye 1815'te başlar ve 1832'deki Paris Haziran Ayaklanması'nda son bulur. Birkaç karakterin yaşamını ve birbirleriyle alakasını ele alan roman daha çok eski mahkûm Jean Valjean'ın yaşam mücadelesi ve kefaretini ödemeye çalışmasına odaklanır.\r\n\r\nYasa ve merhametin doğasının incelendiği roman ayrıca Fransa tarihi, Paris'in mimarisi ve kentsel tasarımı, siyaset, ahlak felsefesi, antimonarşizm, adalet, din, ailevi ve romantik sevginin türleri ve doğası gibi konuları özenle ele alır.\r\n\r\nYayınlanmadan önce büyük tanıtımlar yapılan roman için büyük beklenti de oldu. Roman için birçok yorum yapıldı ama çoğu olumsuzdu. Ticari olarak ise roman sadece Fransa'da değil tüm dünyada büyük başarı yakaladı. Sefiller aralarında bir müzikal ve müzikalden uyarlanan bir filmin de bulunduğu birçok tiyatro, televizyon ve sinema eserine uyarlanarak büyük popülarite elde etti." };
        //var onizleme = new OnIizleme(kitap);
        //var onIzlemeText = onizleme.OnIzlemeSonucu();

        //Console.WriteLine(onIzlemeText);

        Smartphone smartphone1 = new Smartphone
        {
            Brand = "ExampleBrand",
            Model = "ExampleModel",
            OperatingSystem = "ExampleOS",
            StorageCapacity = 64,
        };

        Smartphone smartphone2 = (Smartphone)smartphone1.Clone();

        smartphone2.StorageCapacity = 128;

        Console.WriteLine($"Phone 1: {smartphone1.Brand} {smartphone1.Model} {smartphone1.OperatingSystem} {smartphone1.StorageCapacity}");
        Console.WriteLine($"Phone 2: {smartphone2.Brand} {smartphone2.Model} {smartphone2.OperatingSystem} {smartphone2.StorageCapacity}");
    }
}