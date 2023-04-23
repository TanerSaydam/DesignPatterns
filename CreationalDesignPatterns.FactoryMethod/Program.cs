namespace CreationalDesignPatterns.FactoryMethod;

internal class Program
{
    static void Main(string[] args)
    {
        //WebSiteFactory factory = new WebSiteFactoryBlog();
        //factory.CreateWebSite();

        //WebSiteFactory factoryBlog = new WebSiteFactoryBlog();
        //factoryBlog.CreateWebSite();

        Order order = new Order();
        order.AddOrderItem(new HamburgerCreator());
        order.AddOrderItem(new PizzaCreator());
        order.PrepareOrder();

        Console.WriteLine("Hello, World!");
    }
}