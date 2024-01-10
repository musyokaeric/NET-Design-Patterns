// Dependency Inversion Principle (DIP):
// =====================================
// High - level modules should not depend on low-level modules; both should depend on abstractions.
// Abstractions should not depend on details; details should depend on abstractions.

// Real-life Example: Notification System
// ======================================
// In a notification system, high-level modules (e.g., business logic)
// should not depend on low-level modules (e.g., specific notification methods).
// Instead, both should depend on abstractions.

// Without DIP
public class EmailNotification
{
    public void SendEmail(string to, string message)
    {
        // Code to send an email
        Console.WriteLine("Send email notification");
    }
}

public class NotificationService
{
    private EmailNotification emailNotification;

    public NotificationService(EmailNotification emailNotification)
    {
        this.emailNotification = emailNotification;
    }

    public void NotifyUser(string to, string message)
    {
        // Business logic
        emailNotification.SendEmail(to, message);
    }
}

// With DIP
public interface INotification
{
    void SendNotification(string to, string message);
}

public class EmailNotification2 : INotification
{
    public void SendNotification(string to, string message)
    {
        // Code to send an email
        Console.WriteLine("Send email notification");
    }
}

public class NotificationService2
{
    private INotification notification;

    public NotificationService2(INotification notification)
    {
        this.notification = notification;
    }

    public void NotifyUser(string to, string message)
    {
        // Business logic
        notification.SendNotification(to, message);
    }
}
