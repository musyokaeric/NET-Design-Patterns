// Singleton Pattern:
// ==================
// Ensures a class has only one instance and provides a global point of access to it.

// Usage:
// ======
Singleton obj = Singleton.Instance;

// Real-life Use Case: Logging Service in a Software Application:
// ==============================================================
// In many software applications, you need a centralized logging service to log various
// events and messages. Using a Singleton pattern ensures that there is only one instance
// of the logging service throughout the application.

// Usage:
// ======
Logger.Instance.Log("Application started");
Logger.Instance.Log("User logged in");

// In this example, the "Logger" class is a Singleton, ensuring that there is only one instance
// of the logging service. This centralized logging service can be accessed from different parts of the application.