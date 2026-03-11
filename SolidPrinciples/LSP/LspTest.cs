using NUnit.Framework;

namespace SolidPrinciples.LSP;

[TestFixture]
public class LspTest
{
    [Test, Description("Test rectangle area")]
    public void Rectangle_Shape_Area()
    {
        const double height = 10;
        const double width = 5;
        
        Shape rectangle = new Rectangle
        {
            Height = height,
            Width = width
        };

        Assert.AreEqual(rectangle.Area, height * width);
    }

    [Test, Description("Test square area")]
    public void Square_Shape_Area()
    {
        const double length = 10;

        Shape square = new Square()
        {
            Length = length
        };

        Assert.AreEqual(square.Area, length * length);
    }
}