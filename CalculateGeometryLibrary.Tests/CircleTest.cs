namespace CalculateGeometryLibrary.Tests;

public class CircleTest
{
    [Test]
    public void Constructor_CreateModel_Success()
    {
        const int expectedRadius = 5;
        
        var circle = new Circle(expectedRadius);
        
        Assert.That(circle.Radius, Is.EqualTo(expectedRadius));
    }

    [Test]
    public void Constructor_SetMinesValue_Failed()
    {
        const int value = -1;
        
        Assert.Throws<ArgumentException>(() =>
        {
            var circle = new Circle(value);
        });
    }
    
    [Test]
    public void Constructor_SetZeroValue_Failed()
    {
        const int value = 0;
        
        Assert.Throws<ArgumentException>(() =>
        {
            var circle = new Circle(value);
        });
    }
}