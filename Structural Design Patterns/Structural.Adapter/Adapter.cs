// Adapter Pattern:
// ================
// Intent: Convert the interface of a class into another interface clients expect.
// Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.

// Existing class
public class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Adaptee's specific request");
    }
}

// Target interface
public interface ITarget
{
    void Request();
}

// Adapter
public class Adapter : ITarget
{
    private Adaptee adaptee;

    public Adapter(Adaptee adaptee)
    {
        this.adaptee = adaptee;
    }

    public void Request()
    {
        adaptee.SpecificRequest();
    }
}


// Real-life Use Case - Legacy System Integration
// ==============================================
// Scenario:
// Imagine you have a legacy system that communicates with an external service using a specific
// interface. However, the new system you are building expects a different interface. To bridge this gap
// without modifying the existing code, you can use the Adapter pattern.

// Example:
// Consider a scenario where the legacy system uses SOAP web services, but your new system expects data
// in JSON format. You can create an adapter to convert the SOAP calls to JSON format.

// Legacy system using SOAP
class LegacySystem
{
    public void MakeSoapCall()
    {
        Console.WriteLine("Making SOAP call");
    }
}

// Adapter to convert SOAP to JSON
class JsonAdapter : ITarget
{
    private LegacySystem legacySystem;

    public JsonAdapter(LegacySystem legacySystem)
    {
        this.legacySystem = legacySystem;
    }

    public void Request()
    {
        legacySystem.MakeSoapCall();
        // Additional logic to convert SOAP to JSON
        Console.WriteLine("Converting SOAP to JSON");
    }
}
