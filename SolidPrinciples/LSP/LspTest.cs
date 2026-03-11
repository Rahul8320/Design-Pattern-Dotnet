using NUnit.Framework;

namespace SolidPrinciples.LSP;

[TestFixture]
public class LspTest
{
    [Test, Description("Test rectangle area")]
    public void Test_Rectangle_Area()
    {
        const double height = 10;
        const double width = 5;
        var rectangle = new Rectangle
        {
            Height = height,
            Width = width
        };

        Assert.AreEqual(rectangle.Width, width);
        Assert.AreEqual(rectangle.Height, height);
        Assert.AreEqual(rectangle.Area, height * width);
    }

    [Test, Description("Test square area")]
    public void Test_Square_Area()
    {
        const double height = 10;
        const double width = 5;
        var rectangle = new Square()
        {
            Height = height,
            Width = width
        };

        Assert.AreEqual(rectangle.Width, width);
        Assert.AreEqual(rectangle.Height, height);
        Assert.AreEqual(rectangle.Area, height * width);
    }
}