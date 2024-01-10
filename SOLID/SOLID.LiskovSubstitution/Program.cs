// Liskov Substitution Principle (LSP):
// ====================================
// Subtypes must be substitutable for their base types
// without altering the correctness of the program.

// Real-life Example: Shapes
// =========================
// In a graphics system, shapes should be substitutable for
// one another without affecting the correctness of the program.

// Without LSP
public class Rectangle
{
    public virtual void SetWidth(int width)
    {
        // Code to set the width
        Console.WriteLine("Width: " + width);
    }

    public virtual void SetHeight(int height)
    {
        // Code to set the height
        Console.WriteLine("Height: " + height);
    }
}

public class Square : Rectangle
{
    public override void SetWidth(int width)
    {
        base.SetWidth(width);
        base.SetHeight(width); // This violates LSP
    }
}

// With LSP
public interface IShape
{
    void SetDimensions(int width, int height);
}

public class Rectangle2 : IShape
{
    public void SetDimensions(int width, int height)
    {
        // Code to set the width and height
        Console.WriteLine("Width: " + width);
        Console.WriteLine("Height: " + height);
    }
}

public class Square2 : IShape
{
    public void SetDimensions(int width, int height)
    {
        // Code to set both dimensions, ensuring LSP
        Console.WriteLine("Width: " + width);
        Console.WriteLine("Height: " + height);
    }
}
