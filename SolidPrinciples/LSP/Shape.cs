namespace SolidPrinciples.LSP;

public abstract class Shape
{
    public abstract double Width { get; set; }
    public abstract double Height { get; set; }
    public double Area => Width * Height;
}