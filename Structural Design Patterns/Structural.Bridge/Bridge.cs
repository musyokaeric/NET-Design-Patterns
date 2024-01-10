// Bridge Pattern:
// ===============
// Separates abstraction from implementation so that the two can vary independently.

// Implementor interface
public interface IImplementor
{
    void OperationImp();
}

// ConcreteImplementor
public class ConcreteImplementorA : IImplementor
{
    public void OperationImp()
    {
        Console.WriteLine("ConcreteImplementorA operation");
    }
}
public class ConcreteImplementorB : IImplementor
{
    public void OperationImp()
    {
        Console.WriteLine("ConcreteImplementorB operation");
    }
}

// Abstraction
public abstract class Abstraction
{
    protected IImplementor implementor;

    public Abstraction(IImplementor implementor)
    {
        this.implementor = implementor;
    }

    public abstract void Operation();
}

// RefinedAbstraction
public class RefinedAbstraction : Abstraction
{
    public RefinedAbstraction(IImplementor implementor) : base(implementor)
    {
    }

    public override void Operation()
    {
        implementor.OperationImp();
    }
}

// Real-Life Use Case:
// ===================
// In GUI frameworks, the bridge pattern is often used to separate platform-specific code (e.g., Windows, Linux, macOS)
// from the higher-level user interface code. The platform-specific code serves as the implementor, and the UI code
// acts as the abstraction, allowing the UI to vary independently from the platform.

// Implementor interface
public interface IDrawingAPI
{
    void DrawCircle(int radius);
}

// ConcreteImplementor for Windows
public class WindowsDrawingAPI : IDrawingAPI
{
    public void DrawCircle(int radius)
    {
        Console.WriteLine($"Drawing Circle on Windows with radius {radius}");
    }
}

// ConcreteImplementor for Linux
public class LinuxDrawingAPI : IDrawingAPI
{
    public void DrawCircle(int radius)
    {
        Console.WriteLine($"Drawing Circle on Linux with radius {radius}");
    }
}

// Abstraction for shapes
public abstract class Shape
{
    protected IDrawingAPI drawingAPI;

    protected Shape(IDrawingAPI drawingAPI)
    {
        this.drawingAPI = drawingAPI;
    }

    public abstract void Draw();
}

// RefinedAbstraction for Circle
public class Circle : Shape
{
    private int radius;

    public Circle(int radius, IDrawingAPI drawingAPI) : base(drawingAPI)
    {
        this.radius = radius;
    }

    public override void Draw()
    {
        drawingAPI.DrawCircle(radius);
    }
}
