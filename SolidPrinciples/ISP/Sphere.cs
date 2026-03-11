namespace SolidPrinciples.ISP;

public class Sphere(double radius) : IShape3D
{
    private double Radius { get; } = radius;

    public double Area()
    {
        return 4 * Math.PI * Radius * Radius;
    }

    public double Volume()
    {
        return (4.0 / 3.0) * Math.PI * Radius * Radius;
    }
}