// Strategy Pattern:
// =================
// Intent: Define a family of algorithms, encapsulate each one, and make them interchangeable.
// Strategy lets the algorithm vary independently from clients that use it.
// Example in .NET:
// Imagine a sorting algorithm strategy where you can switch between different sorting algorithms.

// Example usage
var list = new List<int> { 5, 2, 8, 1, 7 };

var sorter = new Sorter(new BubbleSortStrategy());
sorter.Sort(list);

sorter.SetSortStrategy(new QuickSortStrategy());
sorter.Sort(list);

// Real - life Use Case: Payment Processing
// ========================================
// Use Case:
// In a payment processing system, different payment methods (credit card, PayPal, etc.) can be implemented
// as separate strategies. The strategy pattern allows the system to switch between payment methods dynamically.
// Example in .NET:
// Consider an e-commerce application where users can choose between different payment methods during checkout.

// Example usage
var creditCardPayment = new CreditCardPayment();
var payPalPayment = new PayPalPayment();

var paymentProcessor = new PaymentProcessor();
paymentProcessor.SetPaymentStrategy(creditCardPayment);
paymentProcessor.ProcessPayment(50.0);  // Paid $50.00 using Credit Card

paymentProcessor.SetPaymentStrategy(payPalPayment);
paymentProcessor.ProcessPayment(30.0);  // Paid $30.00 using PayPal
