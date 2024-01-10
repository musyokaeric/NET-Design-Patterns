// Single Responsibility Principle (SRP):
// ======================================
// - A class should have only one reason to change.
// - It should have only one responsibility.

// Real - life Example: Logger
// ===========================
// In a logging system, a class responsible for writing logs should have the
// single responsibility of writing logs and not be concerned with formatting or storage.

// Without SRP
public class Logger
{
    public void LogToFile(string message)
    {
        // Code to log message to a file
        Console.WriteLine("Logged to file: " + message);
    }

    public void LogToDatabase(string message)
    {
        // Code to log message to a database
        Console.WriteLine("Logged to database: " + message);
    }
}

// With SRP
public class FileLogger
{
    public void Log(string message)
    {
        // Code to log message to a file
        Console.WriteLine("Logged to file: " + message);
    }
}

public class DatabaseLogger
{
    public void Log(string message)
    {
        // Code to log message to a database
        Console.WriteLine("Logged to file: " + message);
    }
}
