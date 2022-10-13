// See https://aka.ms/new-console-template for more information
using CalculateGeometryLibrary;

var triangle = new Triangle(3, 4, 5);
var circle = new Circle(4);

Console.WriteLine(ShapeSquareCalculator.GetShapeSquare(triangle));
Console.WriteLine(triangle.IsTriangleRight);
Console.WriteLine(ShapeSquareCalculator.GetShapeSquare(circle));