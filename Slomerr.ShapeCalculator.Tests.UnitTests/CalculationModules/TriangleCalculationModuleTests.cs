using Slomerr.ShapeCalculator.DefaultCalculationModules;
using Slomerr.ShapeCalculator.DefaultShapes;
using Slomerr.ShapeCalculator.Exceptions;

namespace Slomerr.ShapeCalculator.Tests.UnitTests.CalculationModules;

public sealed class TriangleCalculationModuleTests
{
    [Theory]
    [InlineData(13, 12, 14, 72.3079, 4)]
    [InlineData(16, 15, 7, 52.306787, 4)]
    public void GetSquare(float a, float b, float c, double square, int round = 4)
    {
        var triangle = new Triangle(a, b, c);
        var module = new TriangleCalculationModule();
        var result = module.GetSquare(ref triangle);
        Assert.Equal(Math.Round(square, round), Math.Round(result, round));
    }

    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(-1, -1, -1)]
    [InlineData(1, 1, 2)]
    public void GetSquareWithWrongSides(float a, float b, float c)
    {
        Assert.Throws<WrongSidesOfTriangleException>(() => new Triangle(a, b, c));
    }

    [Fact]
    public void WrongShape()
    {
        var otherShape = new TestShape();
        var module = new TriangleCalculationModule();
        Assert.Throws<WrongShapeTypeException>(() => module.GetSquare(ref otherShape));
    }

    private class TestShape : IShape
    {
        
    }
}