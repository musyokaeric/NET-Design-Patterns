// With LSP
public interface IFlyable
{
    void Fly();
}

public class Bird2 : IFlyable
{
    public void Fly()
    {
        // Fly behavior for a generic bird
        Console.WriteLine("Fly");
    }
}

public class Penguin2 : IFlyable
{
    public void Fly()
    {
        // Penguins can't fly, so this method is empty
    }
}

// Now, both "Bird" and "Penguin" implement the "IFlyable" interface,
// making them substitutable without breaking expectations.