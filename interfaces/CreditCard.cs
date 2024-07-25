namespace interfaces;

public interface IPaymentProcessors
{
    void ProcessPayment(decimal amount);
}

public class CreditCardProcessor : IPaymentProcessors
{
    public void ProcessPayment(decimal amount)
    {
       Console.WriteLine($"payment processing for {amount } dollar."); 
    }
}

public class PayPalProcessor : IPaymentProcessors
{
    public void ProcessPayment(decimal amount)
    {
       Console.WriteLine($"For paypal payment processing for {amount } dollar."); 
    }
}

public class PaymentService
{
    private readonly IPaymentProcessors _processor;

    public PaymentService(IPaymentProcessors processor)
    {
        _processor = processor;
    }

    public void ProcessOrderPayment(decimal amount)
    {
        _processor.ProcessPayment(amount);
    }
}