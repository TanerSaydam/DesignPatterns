namespace BehavioralDesignPatterns.Visitor.Visitor1;

public interface IElement
{
    void Accept(IVisitor visitor);
}

public class ConcreteElementA : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public string OperationA()
    {
        return "ConcreteElementA işlemi";
    }
}

public class ConcreteElementB : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public string OperationB()
    {
        return "ConcreteElementB işlemi";
    }
}

public interface IVisitor
{
    void Visit(ConcreteElementA elementA);
    void Visit(ConcreteElementB elementB);
}

public class ConcreteVisitor : IVisitor
{
    public void Visit(ConcreteElementA elementA)
    {
        Console.WriteLine($"ConcreteVisitor ziyaterçisi, {elementA.OperationA()} işlemi gerçekleştiriyor.");
    }

    public void Visit(ConcreteElementB elementB)
    {
        Console.WriteLine($"ConcreteVisitor ziyaterçisi, {elementB.OperationB()} işlemi gerçekleştiriyor.");
    }
}
