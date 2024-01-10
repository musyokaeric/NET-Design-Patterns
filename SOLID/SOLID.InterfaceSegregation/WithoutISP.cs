// Without ISP
public interface IWorker
{
    void Work();
    void TakeBreak();
}

public class Manager : IWorker
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

// This violates ISP because not all classes that
// implement "IWorker" need both "Work" and "TakeBreak" methods.