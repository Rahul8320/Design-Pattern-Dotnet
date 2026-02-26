namespace SolidPrinciples.OCP;

/// <summary>
/// This class need to modify every time we are adding new shape. 
/// Might be need new field to store new shape data or calculating area logic.
/// </summary>
public class Shape
{
    public ShapeType Type { get; set; }
    public double Radius { get; set; }
    public double Width { get; set; }
    public double Length { get; set; }

    public double CalculateArea()
    {
        return Type switch
        {
            ShapeType.Circle => Math.Round(Math.PI * Math.Pow(Radius, 2), 2),
            ShapeType.Rectangle => Math.Round(Length * Width, 2),
            _ => throw new InvalidOperationException("Unsupported shape type!"),
        };
    }
}
