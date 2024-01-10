// Decorator Pattern:
// ==================
// Attach additional responsibilities to an object dynamically. Decorators provide a flexible 
// alternative to subclassing for extending functionality.

// Component interface
public interface IComponent
{
    void Operation();
}

// Concrete component
public class ConcreteComponent : IComponent
{
    public void Operation()
    {
        Console.WriteLine("ConcreteComponent operation");
    }
}

// Decorator
public class Decorator : IComponent
{
    private IComponent component;

    public Decorator(IComponent component)
    {
        this.component = component;
    }

    public void Operation()
    {
        component.Operation();
    }
}

// Concrete decorator
public class ConcreteDecorator : Decorator
{
    public ConcreteDecorator(IComponent component) : base(component)
    {
    }

    public void AdditionalOperation()
    {
        Console.WriteLine("ConcreteDecorator additional operation");
    }
}

// Real-Life Use Case:
// ===================
// Consider a text processing application where you want to provide additional formatting options
// for text. Decorators can be used to add features like bold, italic, or underline to the base text
// without creating a complex hierarchy of classes.

// Component interface
public interface IText
{
    void Display();
}

// ConcreteComponent for PlainText
public class PlainText : IText
{
    private string content;

    public PlainText(string content)
    {
        this.content = content;
    }

    public void Display()
    {
        Console.WriteLine($"Text: {content}");
    }

    public override string ToString()
    {
        return $"Text: {content}";
    }
}

// Decorator for BoldText
public class BoldText : IText
{
    private IText text;

    public BoldText(IText text)
    {
        this.text = text;
    }

    public void Display()
    {
        Console.WriteLine($"<b>{text}</b>");
    }

    public override string ToString()
    {
        return $"<b>{text}</b>";
    }
}

// Decorator for ItalicText
public class ItalicText : IText
{
    private IText text;

    public ItalicText(IText text)
    {
        this.text = text;
    }

    public void Display()
    {
        Console.WriteLine($"<i>{text}</i>");
    }

    public override string ToString()
    {
        return $"<i>{text}</i>";
    }
}
