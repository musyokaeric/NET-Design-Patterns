// Interface Segregation Principle (ISP):
// ======================================
// A class should not be forced to implement interfaces it does not use.

// Real-life Example: Multi-functional Printer
// ===========================================
// In a multi-functional printer, not all clients need all functionalities.
// Applying ISP avoids forcing unnecessary methods on clients.

// Without ISP
public interface IMultiFunctionalDevice
{
    void Print();
    void Scan();
    void Fax();
}

public class SimplePrinter : IMultiFunctionalDevice
{
    public void Print()
    {
        // Code to print
    }

    public void Scan()
    {
        // This method is not relevant for SimplePrinter
    }

    public void Fax()
    {
        // This method is not relevant for SimplePrinter
    }
}

// With ISP
public interface IPrinter
{
    void Print();
}

public interface IScanner
{
    void Scan();
}

public interface IFax
{
    void Fax();
}

public class SimplePrinter2 : IPrinter
{
    public void Print()
    {
        // Code to print
    }
}
