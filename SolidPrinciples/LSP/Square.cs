namespace SolidPrinciples.LSP;

public class Square : Rectangle
{
    public override double Height
    {
        get => base.Height;
        set => base.Height = base.Width = value;
    }

    public override double Width
    {
        get => base.Width;
        set => base.Width = base.Height = value;
    }
}