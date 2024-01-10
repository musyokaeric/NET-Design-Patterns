// With ISP
public interface IWorkable
{
    void Work();
}

public interface IBreakable
{
    void TakeBreak();
}

public class Manager : IWorkable, IBreakable
{
    public void Work()
    {
        // Manager-specific work
        Console.WriteLine("Work");
    }

    public void TakeBreak()
    {
        // Manager-specific break
        Console.WriteLine("Take a break");
    }
}

// Now, classes can implement only the interfaces they need.