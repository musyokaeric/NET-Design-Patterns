// With DIP
public interface ISwitchable
{
    void TurnOn();
    void TurnOff();
}

public class LightBulb2 : ISwitchable
{
    public void TurnOn()
    {
        // Turn on the light bulb
        Console.WriteLine("Light bulb on");
    }

    public void TurnOff()
    {
        // Turn off the light bulb
        Console.WriteLine("Light bulb off");
    }
}

public class Switch2
{
    private ISwitchable device;

    public Switch2(ISwitchable device)
    {
        this.device = device;
    }

    public void Operate()
    {
        // Operate the device
        if (true)
            device.TurnOn();
        else
            device.TurnOff();
    }
}
