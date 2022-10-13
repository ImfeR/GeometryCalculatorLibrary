namespace CalculateGeometryLibrary.Tests;

public class TriangleTest
{
    [Test]
    public void Constructor_CreateModel_Success()
    {
        const int expectedFirstEdge = 3;
        const int expectedSecondEdge = 4;
        const int expectedThirdEdge = 5;
        
        var triangle = new Triangle(expectedFirstEdge, expectedSecondEdge, expectedThirdEdge);
        
        Assert.Multiple(() =>
        {
            Assert.That(triangle.FirstEdge, Is.EqualTo(expectedFirstEdge));
            Assert.That(triangle.SecondEdge, Is.EqualTo(expectedSecondEdge));
            Assert.That(triangle.ThirdEdge, Is.EqualTo(expectedThirdEdge));
        });
    }

    [Test]
    public void Constructor_CreateModelWithToLargeFirstEdge_Failed()
    {
        const int firstEdgeValue = 6;
        const int secondEdgeValue = 2;
        const int thirdEdgeValue = 3;
        
        Assert.Throws<ArgumentException>(() =>
        {
            var triangle = new Triangle(firstEdgeValue, secondEdgeValue, thirdEdgeValue);
        });
    }
    
    [Test]
    public void Constructor_CreateModelWithToLargeSecondEdge_Failed()
    {
        const int firstEdgeValue = 2;
        const int secondEdgeValue = 6;
        const int thirdEdgeValue = 3;
        
        Assert.Throws<ArgumentException>(() =>
        {
            var triangle = new Triangle(firstEdgeValue, secondEdgeValue, thirdEdgeValue);
        });
    }
    
    [Test]
    public void Constructor_CreateModelWithToLargeThirdEdge_Failed()
    {
        int firstEdgeValue = 3;
        int secondEdgeValue = 2;
        int thirdEdgeValue = 6;
        
        Assert.Throws<ArgumentException>(() =>
        {
            var triangle = new Triangle(firstEdgeValue, secondEdgeValue, thirdEdgeValue);
        });
    }

    [Test]
    public void FirstEdge_SetMinesValue_Failed()
    {
        var triangle = new Triangle(3, 5, 4);

        Assert.Throws<ArgumentException>(() =>
        {
            triangle.FirstEdge = -1;
        });
    }
    
    [Test]
    public void FirstEdge_SetZeroValue_Failed()
    {
        var triangle = new Triangle(3, 5, 4);

        Assert.Throws<ArgumentException>(() =>
        {
            triangle.FirstEdge = 0;
        });
    }
    
    [Test]
    public void SecondEdge_SetMinesValue_Failed()
    {
        var triangle = new Triangle(3, 5, 4);

        Assert.Throws<ArgumentException>(() =>
        {
            triangle.SecondEdge = -1;
        });
    }
    
    [Test]
    public void SecondEdge_SetZeroValue_Failed()
    {
        var triangle = new Triangle(3, 5, 4);

        Assert.Throws<ArgumentException>(() =>
        {
            triangle.SecondEdge = 0;
        });
    }
    
    [Test]
    public void ThirdEdge_SetMinesValue_Failed()
    {
        var triangle = new Triangle(3, 5, 4);

        Assert.Throws<ArgumentException>(() =>
        {
            triangle.ThirdEdge = -1;
        });
    }
    
    [Test]
    public void ThirdEdge_SetZeroValue_Failed()
    {
        var triangle = new Triangle(3, 5, 4);

        Assert.Throws<ArgumentException>(() =>
        {
            triangle.ThirdEdge = 0;
        });
    }

    [Test]
    public void IsTriangleRight_GetValueWhenNotRightTriangle_False()
    {
        const bool expectedValue = false;

        var triangle = new Triangle(3, 4, 6);
        
        Assert.That(triangle.IsTriangleRight, Is.EqualTo(expectedValue));
    }
    
    [Test]
    public void IsTriangleRight_GetValueWhenRightTriangle_True()
    {
        const bool expectedValue = true;

        var triangle = new Triangle(3, 4, 5);
        
        Assert.That(triangle.IsTriangleRight, Is.EqualTo(expectedValue));
    }
    
    [Test]
    public void IsTriangleRight_GetValueWhenChanged_True()
    {
        const bool expectedTrueValue = true;
        const bool expectedFalseValue = false;

        var triangle = new Triangle(3, 4, 5);
        
        Assert.That(triangle.IsTriangleRight, Is.EqualTo(expectedTrueValue));

        triangle.ThirdEdge = 6;
        
        Assert.That(triangle.IsTriangleRight, Is.EqualTo(expectedFalseValue));
    }
}