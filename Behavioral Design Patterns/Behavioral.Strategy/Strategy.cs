// Strategy Pattern:
// =================
// Intent: Define a family of algorithms, encapsulate each one, and make them interchangeable.
// Strategy lets the algorithm vary independently from clients that use it.
// Example in .NET:
// Imagine a sorting algorithm strategy where you can switch between different sorting algorithms.

// Strategy
using System.Runtime.Intrinsics.X86;

public interface ISortStrategy
{
    void Sort(List<int> list);
}

// Concrete Strategies
public class BubbleSortStrategy : ISortStrategy
{
    public void Sort(List<int> list)
    {
        Console.WriteLine("Bubble Sort");
        // Implementation of Bubble Sort
    }
}

public class QuickSortStrategy : ISortStrategy
{
    public void Sort(List<int> list)
    {
        Console.WriteLine("Quick Sort");
        // Implementation of Quick Sort
    }
}

// Context
public class Sorter
{
    private ISortStrategy _sortStrategy;

    public Sorter(ISortStrategy sortStrategy)
    {
        _sortStrategy = sortStrategy;
    }

    public void SetSortStrategy(ISortStrategy sortStrategy)
    {
        _sortStrategy = sortStrategy;
    }

    public void Sort(List<int> list)
    {
        _sortStrategy.Sort(list);
    }
}

// Real - life Use Case: Payment Processing
// ========================================
// Use Case:
// In a payment processing system, different payment methods (credit card, PayPal, etc.) can be implemented
// as separate strategies. The strategy pattern allows the system to switch between payment methods dynamically.
// Example in .NET:
// Consider an e-commerce application where users can choose between different payment methods during checkout.

// Strategy
public interface IPaymentStrategy
{
    void ProcessPayment(double amount);
}

// Concrete Strategies
public class CreditCardPayment : IPaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Paid {amount:C} using Credit Card.");
    }
}

public class PayPalPayment : IPaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Paid {amount:C} using PayPal.");
    }
}

// Context
public class PaymentProcessor
{
    private IPaymentStrategy _paymentStrategy;

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void ProcessPayment(double amount)
    {
        _paymentStrategy.ProcessPayment(amount);
    }
}
