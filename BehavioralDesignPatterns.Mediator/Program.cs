using BehavioralDesignPatterns.Mediator.Mediator1;

namespace BehavioralDesignPatterns.Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            IChatRoom room = new ChatRoom();

            User ahmet = new Participant("Ahmet");
            User mehmet = new Participant("Mehmet");
            User ayse = new Participant("Ayşe");

            room.Register(ahmet);
            room.Register(mehmet);
            room.Register(ayse);

            ahmet.Send("Mehmet", "Merhaba, Mehmet. Nasılsın?");
            mehmet.Send("Ahmet", "İyiyim, sen nasılsın Ahmet?");
            ayse.Send("Ahmet", "Ahmet seni dün sinemada görmedim mi?");
        }
    }
}