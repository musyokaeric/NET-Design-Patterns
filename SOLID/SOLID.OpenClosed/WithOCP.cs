// With OCP
public interface IShape
{
    double CalculateArea();
}

public class Circle2 : IShape
{
    public double Radius { get; set; }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public class Square : IShape
{
    public double Side { get; set; }

    public double CalculateArea()
    {
        return Math.Pow(Side, 2);
    }
}

// Now, you can add new shapes without modifying
// existing code, adhering to the OCP.