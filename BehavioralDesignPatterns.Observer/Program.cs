using BehavioralDesignPatterns.Observer.Observer1;
using BehavioralDesignPatterns.Observer.Observer2;
using BehavioralDesignPatterns.Observer.Odev1;

namespace BehavioralDesignPatterns.Observer;

internal class Program
{
    static void Main(string[] args)
    {
        //Observable observable = new();

        //Observer1.Observer observer1 = new("Observer1");
        //Observer1.Observer observer2 = new("Observer2");
        //Observer1.Observer observer3 = new("Observer3");

        //observable.Register(observer1);
        //observable.Register(observer2);
        //observable.Register(observer3);

        //observable.SendMessage("Hello world!");


        //Console.WriteLine("Hello, World!");

        //HavaIstasyonu havaIstasyonu = new();

        //MobileApp mobileApp = new MobileApp();
        //WebsiteApp websiteApp = new WebsiteApp();
        //LCDApp LCDApp = new LCDApp();

        //havaIstasyonu.Register(mobileApp);
        //havaIstasyonu.Register(websiteApp);
        //havaIstasyonu.Register(LCDApp);

        //havaIstasyonu.OlcumleriAyarla(25, 60);
        //havaIstasyonu.UnRegister(websiteApp);
        //havaIstasyonu.OlcumleriAyarla(28, 55);

        StockTracker stockTracker = new StockTracker();

        Department salesDepartment = new("Sales");
        Department inventoryDepartment = new("Inventory");
        Department logisticsDepartment = new("Logistics");

        stockTracker.Register(salesDepartment);
        stockTracker.Register(inventoryDepartment);
        stockTracker.Register(logisticsDepartment);

        stockTracker.UpdateStock("Laptop", 50);
        stockTracker.UpdateStock("Laptop", 40);
        stockTracker.UpdateStock("Domates", 10);
        stockTracker.UpdateStock("Domates", 20);
    }
}