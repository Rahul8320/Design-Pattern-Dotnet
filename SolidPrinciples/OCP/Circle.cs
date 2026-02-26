namespace SolidPrinciples.OCP;

/// <summary>
/// Concert implementation of circle shape
/// </summary>
/// <param name="radius">The radius of the circle</param>
public class Circle(double radius) : Shape
{
    public double Radius { get; init; } = radius;

    public override double CalculateArea()
    {
        return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
    }
}
