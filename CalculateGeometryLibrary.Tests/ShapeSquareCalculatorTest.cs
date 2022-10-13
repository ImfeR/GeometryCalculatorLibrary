namespace CalculateGeometryLibrary.Tests;

public class ShapeSquareCalculatorTest
{
    [Test]
    public void GetShapeSquare_TriangleSquare_Success()
    {
        const double expectedResult = 6;
        
        var triangle = new Triangle(3, 4, 5);
        
        Assert.That(ShapeSquareCalculator.GetShapeSquare(triangle), Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void GetShapeSquare_TriangleSquareLargeValue_Success()
    {
        const double expectedResult = 433012701026193920;
        
        var triangle = new Triangle(999999999, 999999999, 999999999);
        
        Assert.That(ShapeSquareCalculator.GetShapeSquare(triangle), Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void GetShapeSquare_CircleSquare_Success()
    {
        const double expectedResult = 78.540;
        
        var circle = new Circle(5);
        
        Assert.That(ShapeSquareCalculator.GetShapeSquare(circle), Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void GetShapeSquare_CircleSquareLargeValue_Success()
    {
        const double expectedResult = 3141592647306607600;
        
        var circle = new Circle(999999999);
        
        Assert.That(ShapeSquareCalculator.GetShapeSquare(circle), Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void GetShapeSquare_TriangleSquareTryToCalculateWithInvalidParams_Failed()
    {
        var triangle = new Triangle(3, 4, 5);

        triangle.FirstEdge = 20;
        
        Assert.Throws<ArgumentException>(() =>
        {
            ShapeSquareCalculator.GetShapeSquare(triangle);
        });
    }
}