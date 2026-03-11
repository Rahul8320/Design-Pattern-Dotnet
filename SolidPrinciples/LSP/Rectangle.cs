namespace SolidPrinciples.LSP;

public class Rectangle : Shape
{
    public double Width { get; init; }

    public double Height { get; init; }
    
    public override double Area => Width * Height;
}