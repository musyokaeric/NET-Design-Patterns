// Observer Pattern:
// Define a one - to - many dependency between objects so that when one object changes state,
// all its dependents are notified and updated automatically.
// Example in .NET:
// Suppose you have a stock market system where multiple observers (investors) want to be notified when the stock price changes.

// Subject
using System.Runtime.Intrinsics.X86;

public class Stock
{
    private string _symbol;
    private double _price;
    private List<IInvestor> _investors = new List<IInvestor>();

    public Stock(string symbol, double price)
    {
        _symbol = symbol;
        _price = price;
    }

    public void Attach(IInvestor investor)
    {
        _investors.Add(investor);
    }

    public void Detach(IInvestor investor)
    {
        _investors.Remove(investor);
    }

    public void Notify()
    {
        foreach (var investor in _investors)
        {
            investor.Update(this);
        }
    }

    public double Price
    {
        get { return _price; }
        set
        {
            if (_price != value)
            {
                _price = value;
                Notify();
            }
        }
    }

    public string Symbol => _symbol;
}

// Observer
public interface IInvestor
{
    void Update(Stock stock);
}

// Concrete Observer
public class Investor : IInvestor
{
    private string _name;

    public Investor(string name)
    {
        _name = name;
    }

    public void Update(Stock stock)
    {
        Console.WriteLine($"Notified {_name} of {stock.Symbol}'s change to {stock.Price:C}");
    }
}

// Real - life Use Case:  Logging Framework
// ========================================
// Consider a logging framework where different components or modules in a system want to be notified
// when significant events occur, such as errors or warnings. The observer pattern can be used to allow
// these components to subscribe to the logging system and receive notifications when log messages are generated.
// Example in .NET:
// You could create a Logger as the subject and various log listeners as observers. When an event occurs (e.g., an error is logged),
// all registered listeners are notified.

// Subject

public enum LogLevel
{
    Error, Info, Verbose, Warning
}
public class Logger
{
    private List<ILogListener> _listeners = new List<ILogListener>();

    public void Subscribe(ILogListener listener)
    {
        _listeners.Add(listener);
    }

    public void LogMessage(string message, LogLevel level)
    {
        Console.WriteLine($"Logging: {message}");
        NotifyListeners(message, level);
    }

    private void NotifyListeners(string message, LogLevel level)
    {
        foreach (var listener in _listeners)
        {
            listener.OnLogMessage(message, level);
        }
    }
}

// Observer
public interface ILogListener
{
    void OnLogMessage(string message, LogLevel level);
}

// Concrete Observer
public class ConsoleLogListener : ILogListener
{
    public void OnLogMessage(string message, LogLevel level)
    {
        Console.WriteLine($"Console Log: [{level}] {message}");
    }
}

