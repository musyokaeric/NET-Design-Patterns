// Observer Pattern:
// Define a one - to - many dependency between objects so that when one object changes state,
// all its dependents are notified and updated automatically.
// Example in .NET:
// Suppose you have a stock market system where multiple observers (investors) want to be notified when the stock price changes.

// Example usage
var stock = new Stock("XYZ", 100.0);
var investor1 = new Investor("Investor 1");
var investor2 = new Investor("Investor 2");

stock.Attach(investor1);
stock.Attach(investor2);

stock.Price = 105.0;

// Real - life Use Case:  Logging Framework
// ========================================
// Consider a logging framework where different components or modules in a system want to be notified
// when significant events occur, such as errors or warnings. The observer pattern can be used to allow
// these components to subscribe to the logging system and receive notifications when log messages are generated.
// Example in .NET:
// You could create a Logger as the subject and various log listeners as observers. When an event occurs (e.g., an error is logged),
// all registered listeners are notified.

// Example usage
var logger = new Logger();
var consoleListener = new ConsoleLogListener();

logger.Subscribe(consoleListener);

logger.LogMessage("An error occurred!", LogLevel.Error);

