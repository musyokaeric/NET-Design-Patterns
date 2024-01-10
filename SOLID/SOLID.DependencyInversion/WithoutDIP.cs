// Without DIP
public class LightBulb
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

public class Switch
{
    private LightBulb bulb;

    public Switch(LightBulb bulb)
    {
        this.bulb = bulb;
    }

    public void Operate()
    {
        // Operate the light bulb
        if (true)
            bulb.TurnOn();
        else
            bulb.TurnOff();
    }

    // This violates DIP because "Switch" depends on the concrete implementation of "LightBulb".
}
