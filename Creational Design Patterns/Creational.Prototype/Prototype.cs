// Prototype Pattern:
// ==================
// Creates new objects by copying an existing object, known as the prototype.

// Prototype
public interface ICloneableItem
{
    ICloneableItem Clone();
    void Display();
}

// Concrete prototypes
public class ConcreteItemA : ICloneableItem
{
    public string PropertyA { get; set; }

    public ICloneableItem Clone()
    {
        return new ConcreteItemA { PropertyA = this.PropertyA };
    }

    public void Display()
    {
        Console.WriteLine($"ConcreteItemA with PropertyA: {PropertyA}");
    }
}

public class ConcreteItemB : ICloneableItem
{
    public int PropertyB { get; set; }

    public ICloneableItem Clone()
    {
        return new ConcreteItemB { PropertyB = this.PropertyB };
    }

    public void Display()
    {
        Console.WriteLine($"ConcreteItemB with PropertyB: {PropertyB}");
    }
}

// Real-life Use Case: Creating Configurable Objects in a Graphic User Interface (GUI) Library:
// ============================================================================================
// Consider a GUI library where you have predefined UI components like buttons, checkboxes,
// and text fields. Users might want to create variations of these components with different colors,
// sizes, and styles. The Prototype pattern can be applied to clone existing UI components and customize their properties.

// Prototype
public interface IUIComponent
{
    IUIComponent Clone();
    void Display();
}

// Concrete prototypes
public class UIButton : IUIComponent
{
    public string Color { get; set; }
    public int Size { get; set; }

    public IUIComponent Clone()
    {
        return new UIButton { Color = this.Color, Size = this.Size };
    }

    public void Display()
    {
        Console.WriteLine($"Button - Color: {Color}, Size: {Size}");
    }
}

public class UICheckbox : IUIComponent
{
    public string Style { get; set; }
    public bool IsChecked { get; set; }

    public IUIComponent Clone()
    {
        return new UICheckbox { Style = this.Style, IsChecked = this.IsChecked };
    }

    public void Display()
    {
        Console.WriteLine($"Checkbox - Style: {Style}, IsChecked: {IsChecked}");
    }
}
