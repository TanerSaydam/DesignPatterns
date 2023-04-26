namespace StructuralDesignPatterns.Adapter.Adapter1;

public interface IPayment
{
    bool MakePayment(decimal amount);
}

public class PaypalPayment : IPayment
{
    public bool MakePayment(decimal amount)
    {
        Console.WriteLine($"Paypal ile {amount} ₺ ödendi!");
        return true;
    }
}

public class Stripe
{
    public bool Charge(decimal amount)
    {
        Console.WriteLine($"Stripe ile {amount} ₺ ödendi!");
        return true;
    }
}

public class StripPaymentAdapter : IPayment
{
    private Stripe _stripe;

    public StripPaymentAdapter()
    {
        _stripe = new();
    }

    public bool MakePayment(decimal amount)
    {
        return _stripe.Charge(amount);
    }
}

public class PayU
{
    public bool ExecutePayment(decimal amount)
    {
        Console.WriteLine($"PayU ile {amount} ₺ ödendi!");
        return true;
    }
}

public class PayUPaymentAdapter : IPayment
{
    private PayU _payU;

    public PayUPaymentAdapter()
    {
        _payU = new();
    }

    public bool MakePayment(decimal amount)
    {
        return _payU.ExecutePayment(amount);
    }
}

public class ShoppingCart
{
    private IPayment _payment;

    public ShoppingCart(IPayment payment)
    {
        _payment = payment;
    }

    public void CheckOut(decimal amount) 
    {
        if(_payment.MakePayment(amount))
        {
            Console.WriteLine("Ödeme işlemi başarıyla tamamlandı!");
        }
        else
        {
            Console.WriteLine("Ödeme işlemi başarısız oldu!");
        }
    }
}
