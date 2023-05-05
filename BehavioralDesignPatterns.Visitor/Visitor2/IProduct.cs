namespace BehavioralDesignPatterns.Visitor.Visitor2;

public interface IProduct
{
    void Accept(ITaxVisitor taxVisitor);
}

public class Book : IProduct
{
    public double Price { get; set; }

    public Book(double price)
    {
        Price = price;
    }

    public void Accept(ITaxVisitor taxVisitor)
    {
        taxVisitor.Visit(this);
    }
}

public class Electronic : IProduct
{
    public double Price { get; set; }

    public Electronic(double price)
    {
        Price = price;
    }

    public void Accept(ITaxVisitor taxVisitor)
    {
        taxVisitor.Visit(this);
    }
}

public interface ITaxVisitor
{
    void Visit(Book book);
    void Visit(Electronic electronic);
}

public class TaxCalculator : ITaxVisitor
{
    public void Visit(Book book)
    {
        double tax = book.Price * 0.08;
        Console.WriteLine($"Kitap için hesaplanan vergi: {tax}");
    }

    public void Visit(Electronic electronic)
    {
        double tax = electronic.Price * 0.18;
        Console.WriteLine($"Elektronik için hesaplanan vergi: {tax}");
    }
}
