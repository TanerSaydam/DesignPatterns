namespace BehavioralDesignPatterns.ChainOfResponsibility.ChainOfResponsibility1;

public class Sales
{
    public Sales(decimal amount)
    {
        Amount = amount;
    }

    public decimal Amount {  get; set; }
    public decimal Discount { get; set; }
    public decimal FinalDiscount { get; set; }
}

public abstract class DiscountHandler
{
    protected DiscountHandler nextHandler;

    public void SetNextHandler(DiscountHandler handler)
    {
        nextHandler = handler;
    }

    public abstract void ApplyDiscount(Sales sale);
}

public class FivePercentDiscountHandler : DiscountHandler
{
    public override void ApplyDiscount(Sales sale)
    {
        if(sale.Amount >= 100 && sale.Amount < 200)
        {
            sale.Discount = sale.Amount * 0.05m;
            sale.FinalDiscount = sale.Amount - sale.Discount;
        }else if(nextHandler != null)
        {
            nextHandler.ApplyDiscount(sale);
        }
    }
}

public class TenPercentDiscountHandler: DiscountHandler
{
    public override void ApplyDiscount(Sales sale)
    {
        if(sale.Amount >= 200)
        {
            sale.Discount = sale.Amount * 0.1m;
            sale.FinalDiscount = sale.Amount - sale.Discount;
        }
        else if (nextHandler != null)
        {
            nextHandler.ApplyDiscount(sale);
        }
    }
}
