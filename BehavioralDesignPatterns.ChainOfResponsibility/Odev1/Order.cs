namespace BehavioralDesignPatterns.ChainOfResponsibility.Odev1;

public class Order
{
    public Order(string customerName, decimal amount)
    {
        CustomerName = customerName;
        Amount = amount;
        Total = amount;
    }

    public string CustomerName { get; set; }
    public decimal Amount { get; set; }
    public decimal Discount { get; set; }
    public decimal Total { get; set; }
}

public abstract class DiscountHandler
{
    protected DiscountHandler nextHandler;
    public void SetNextHandler(DiscountHandler handler)
    {
        nextHandler = handler;
    }

    public abstract void ApplyDiscount(Order order);
}

public class BronzeCustomerDiscountHandler : DiscountHandler
{
    public override void ApplyDiscount(Order order)
    {
        if(order.Amount >= 50 && order.Amount < 100)
        {
            order.Discount = order.Amount * 0.1m;
            order.Total = order.Amount - order.Discount;
        }else if(nextHandler != null)
        {
            nextHandler.ApplyDiscount(order);
        }
    }
}

public class SilverCustomerDiscountHandler : DiscountHandler
{
    public override void ApplyDiscount(Order order)
    {
        if (order.Amount >= 100 && order.Amount < 500)
        {
            order.Discount = order.Amount * 0.15m;
            order.Total = order.Amount - order.Discount;
        }
        else if (nextHandler != null)
        {
            nextHandler.ApplyDiscount(order);
        }
    }
}

public class GoldCustomerDiscountHandler : DiscountHandler
{
    public override void ApplyDiscount(Order order)
    {
        if (order.Amount >= 500)
        {
            order.Discount = order.Amount * 0.2m;
            order.Total = order.Amount - order.Discount;
        }
        else if (nextHandler != null)
        {
            nextHandler.ApplyDiscount(order);
        }
    }
}
