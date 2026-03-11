namespace SolidPrinciples.LSP;

public class Square : Shape
{
    public double Length { get; set; }
    
    public override double Area => Length * Length;
}