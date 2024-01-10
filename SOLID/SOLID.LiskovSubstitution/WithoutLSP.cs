// Without LSP
public class Bird
{
    public virtual void Fly()
    {
        // Fly behavior for a generic bird
        Console.WriteLine("Fly");
    }
}

public class Penguin : Bird
{
    public override void Fly()
    {
        // Penguins can't fly, so this method is empty
    }
}

// This violates LSP because a client expecting a generic bird
// cannot safely substitute a penguin.