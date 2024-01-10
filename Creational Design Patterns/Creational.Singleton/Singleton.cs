// Singleton Pattern:
// ==================
// Ensures a class has only one instance and provides a global point of access to it.

public class Singleton
{
    private static Singleton instance;

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
    }
}

// Real-life Use Case: Logging Service in a Software Application:
// ==============================================================
// In many software applications, you need a centralized logging service to log various
// events and messages. Using a Singleton pattern ensures that there is only one instance
// of the logging service throughout the application.

public class Logger
{
    private static Logger instance;

    private Logger() { }

    public static Logger Instance
    {
        get
        {
            if (instance == null)
                instance = new Logger();
            return instance;
        }
    }

    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }
}
