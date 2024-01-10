// Composite Pattern:
// ==================
// Compose objects into tree structures to represent part-whole hierarchies.  Composite lets 
// clients treat individual objects and compositions of objects uniformly.

// Component interface
public interface IComponent
{
    void Display();
}

// Leaf
public class Leaf : IComponent
{
    private string name;

    public Leaf(string name)
    {
        this.name = name;
    }

    public void Display()
    {
        Console.WriteLine($"Leaf: {name}");
    }
}

// Composite
public class Composite : IComponent
{
    private List<IComponent> children = new List<IComponent>();

    public void Add(IComponent component)
    {
        children.Add(component);
    }

    public void Display()
    {
        foreach (var child in children)
        {
            child.Display();
        }
    }
}

// Real-Life Use Case:
// ===================
// Consider a file system where directories can contain both files and subdirectories.
// The composite pattern can be used to represent files and directories uniformly, allowing you
// to perform operations on the entire file system or individual files and directories.

// Component interface
public interface IFileSystemItem
{
    void Display();
}

// Leaf for File
public class File : IFileSystemItem
{
    private string name;

    public File(string name)
    {
        this.name = name;
    }

    public void Display()
    {
        Console.WriteLine($"File: {name}");
    }
}

// Composite for Directory
public class Directory : IFileSystemItem
{
    private string name;
    private List<IFileSystemItem> items = new List<IFileSystemItem>();

    public Directory(string name)
    {
        this.name = name;
    }

    public void AddItem(IFileSystemItem item)
    {
        items.Add(item);
    }

    public void Display()
    {
        Console.WriteLine($"Directory: {name}");
        foreach (var item in items)
        {
            item.Display();
        }
    }
}
