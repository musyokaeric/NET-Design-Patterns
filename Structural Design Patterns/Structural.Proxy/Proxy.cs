// Proxy Pattern:
// ==============
// Provides a surrogate or placeholder for another object to control access to it.

// Subject interface
public interface ISubject
{
    void Request();
}

// RealSubject
public class RealSubject : ISubject
{
    public void Request()
    {
        Console.WriteLine("RealSubject request");
    }
}

// Proxy
public class Proxy : ISubject
{
    private RealSubject realSubject;

    public void Request()
    {
        if (realSubject == null)
        {
            realSubject = new RealSubject();
        }
        realSubject.Request();
    }
}

// Real-Life Use Case:
// ===================
// Consider a scenario where you are working with large images or documents that take a
// considerable amount of time to load. Instead of loading the entire content upfront,
// a proxy object can be used to represent the image or document. The actual loading
// is deferred until the content is requested.

// Subject interface
public interface IImage
{
    void Display();
}

// RealSubject
public class RealImage : IImage
{
    private string fileName;

    public RealImage(string fileName)
    {
        this.fileName = fileName;
        LoadImageFromDisk();
    }

    private void LoadImageFromDisk()
    {
        Console.WriteLine($"Loading image from disk: {fileName}");
    }

    public void Display()
    {
        Console.WriteLine($"Displaying image: {fileName}");
    }
}

// Proxy
public class ImageProxy : IImage
{
    private RealImage realImage;
    private string fileName;

    public ImageProxy(string fileName)
    {
        this.fileName = fileName;
    }

    public void Display()
    {
        if (realImage == null)
        {
            realImage = new RealImage(fileName);
        }
        realImage.Display();
    }
}
