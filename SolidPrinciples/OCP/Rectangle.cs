namespace SolidPrinciples.OCP;

/// <summary>
/// Concert implementation of rectangle shape class.
/// </summary>
/// <param name="length">The length of the rectangle</param>
/// <param name="width">The width of the rectangle</param>
public class Rectangle(double length, double width) : Shape
{
    public double Length { get; init; } = length;
    public double Width { get; init; } = width;

    public override double CalculateArea()
    {
        return Math.Round(Length * Width, 2);
    }
}
