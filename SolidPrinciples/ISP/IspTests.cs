using NUnit.Framework;

namespace SolidPrinciples.ISP;

[TestFixture]
public class IspTests
{
    [Test]
    public void Test2DObject()
    {
        const double radius = 5;
        var circle = new Circle(radius);

        Assert.AreEqual(circle.Area(), Math.PI * radius * radius);
    }

    [Test]
    public void Test3DObject()
    {
        const double radius = 5;
        var sphere = new Sphere(radius);

        Assert.AreEqual(sphere.Area(), 4 * Math.PI * radius * radius);
        Assert.AreEqual(sphere.Volume(), (4.0 / 3.0) * Math.PI * radius * radius);
    }
}