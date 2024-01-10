// Facade Pattern:
// ===============
// Provides a simplified interface to a set of interfaces in a subsystem that makes the subsystem easier to use.

// Subsystem components
public class SubsystemA
{
    public void OperationA()
    {
        Console.WriteLine("SubsystemA operation");
    }
}

public class SubsystemB
{
    public void OperationB()
    {
        Console.WriteLine("SubsystemB operation");
    }
}

public class SubsystemC
{
    public void OperationC()
    {
        Console.WriteLine("SubsystemC operation");
    }
}

// Facade
public class Facade
{
    private SubsystemA subsystemA;
    private SubsystemB subsystemB;
    private SubsystemC subsystemC;

    public Facade()
    {
        subsystemA = new SubsystemA();
        subsystemB = new SubsystemB();
        subsystemC = new SubsystemC();
    }

    public void Operation()
    {
        subsystemA.OperationA();
        subsystemB.OperationB();
        subsystemC.OperationC();
    }
}


// Real-Life Use Case:
// ===================
// In a multimedia application, you might have complex subsystems for handling audio,
// video, and graphics. A facade can simplify the process of playing a multimedia file
// by providing a single interface that internally handles the complexities of each subsystem.

// Subsystem components
public class AudioSubsystem
{
    public void PlayAudio(string fileName)
    {
        Console.WriteLine($"Playing audio: {fileName}");
    }
}

public class VideoSubsystem
{
    public void PlayVideo(string fileName)
    {
        Console.WriteLine($"Playing video: {fileName}");
    }
}

public class GraphicsSubsystem
{
    public void RenderGraphics(string fileName)
    {
        Console.WriteLine($"Rendering graphics: {fileName}");
    }
}

// Facade
public class MultimediaFacade
{
    private AudioSubsystem audioSubsystem;
    private VideoSubsystem videoSubsystem;
    private GraphicsSubsystem graphicsSubsystem;

    public MultimediaFacade()
    {
        audioSubsystem = new AudioSubsystem();
        videoSubsystem = new VideoSubsystem();
        graphicsSubsystem = new GraphicsSubsystem();
    }

    public void PlayMultimediaFile(string fileName)
    {
        audioSubsystem.PlayAudio(fileName);
        videoSubsystem.PlayVideo(fileName);
        graphicsSubsystem.RenderGraphics(fileName);
    }
}
