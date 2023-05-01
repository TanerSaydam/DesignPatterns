using BehavioralDesignPatterns.Mediator.Mediator1;
using BehavioralDesignPatterns.Mediator.Mediator2;
using BehavioralDesignPatterns.Mediator.Odev1;

namespace BehavioralDesignPatterns.Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //IChatRoom room = new ChatRoom();

            //User ahmet = new Participant("Ahmet");
            //User mehmet = new Participant("Mehmet");
            //User ayse = new Participant("Ayşe");

            //room.Register(ahmet);
            //room.Register(mehmet);
            //room.Register(ayse);

            //ahmet.Send("Mehmet", "Merhaba, Mehmet. Nasılsın?");
            //mehmet.Send("Ahmet", "İyiyim, sen nasılsın Ahmet?");
            //ayse.Send("Ahmet", "Ahmet seni dün sinemada görmedim mi?");

            //IHavaTrafikKontrol atc = new HavaTrafikKontrol();

            //HavadakiUcak ucak1 = new("Uçak 1", atc);
            //HavadakiUcak ucak2 = new("Uçak 2", atc);
            //HavadakiUcak ucak3 = new("Uçak 3", atc);
            //HavadakiUcak ucak4 = new("Uçak 4", atc);

            //ucak1.InisIzniIste();
            //ucak2.InisIzniIste();
            //ucak3.InisIzniIste();
            //ucak4.InisIzniIste();

            //ucak1.InisiTamamladiginiBildir();
            //ucak2.InisiTamamladiginiBildir();
            //ucak3.InisiTamamladiginiBildir();
            //ucak4.InisiTamamladiginiBildir();

            IShoppingMalMediator shoppingMalMediator = new ShoppingMalMediator();

            Store store1 = new("Mağaza 1", shoppingMalMediator);
            Store store2 = new("Mağaza 2", shoppingMalMediator);

            Visitor visitor = new("Taner", shoppingMalMediator);

            store1.AnnounceDiscount("Ayakkabılarda %50 indirim!");
            store2.AnnounceEvent("Açılış partisine davetlisiniz!");

            visitor.CheckDiscounts();
            visitor.CheckEvents();
        }
    }
}