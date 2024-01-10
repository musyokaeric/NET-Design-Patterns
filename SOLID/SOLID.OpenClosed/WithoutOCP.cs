// Without OCP
public class Circle
{
    public double Radius { get; set; }
}

public class AreaCalculator
{
    public double CalculateArea(Circle circle)
    {
        return Math.PI * Math.Pow(circle.Radius, 2);
    }
}

// This violates OCP because if you want to add support for calculating
// the area of a square, you'd have to modify the "AreaCalculator" class.