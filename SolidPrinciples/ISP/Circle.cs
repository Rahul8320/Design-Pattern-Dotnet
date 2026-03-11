namespace SolidPrinciples.ISP;

public class Circle(double radius) : IShape2D
{
    private double Radius { get; } = radius;

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }
}