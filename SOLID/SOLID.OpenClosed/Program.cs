// Open / Closed Principle(OCP):
// =============================
// Software entities(classes, modules, functions, etc.) should be open for
// extension but closed for modification.

// Real-life Example: Payment System
// =================================
// In a payment system, you may have different payment methods. The system
// should be open for adding new payment methods without modifying existing code.

// Without OCP
public class PaymentProcessor
{
    public void ProcessCreditCardPayment(decimal amount)
    {
        // Code to process credit card payment
    }

    // If a new payment method is added, you'd have to modify this class.
}

// With OCP
public interface IPaymentMethod
{
    void ProcessPayment(decimal amount);
}

public class CreditCardPayment : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        // Code to process credit card payment
        Console.WriteLine("Credit card payment, amount " + amount);
    }
}

public class PayPalPayment : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        // Code to process PayPal payment
        Console.WriteLine("Paypal payment, amount " + amount);
    }
}
