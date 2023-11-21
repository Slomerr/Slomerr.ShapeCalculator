using Slomerr.ShapeCalculator.DefaultCalculationModules;
using Slomerr.ShapeCalculator.DefaultShapes;
using Slomerr.ShapeCalculator.Exceptions;

namespace Slomerr.ShapeCalculator.Tests.UnitTests.CalculationModules;

public sealed class CircleCalculationModuleTests
{
    [Theory]
    [InlineData(1, Math.PI)]
    [InlineData(15, 706.8583)]
    public void GetSquare(float radius, double square, int round = 4)
    {
        var circle = new Circle(radius);
        var module = new CircleCalculationModule();
        var result = module.GetSquare(ref circle);
        Assert.Equal(Math.Round(square, round), Math.Round(result, round));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(-200)]
    public void GetSquareWithWrongRadius(float radius)
    {
        Assert.Throws<NegativeOrZeroRadiusException>(() => new Circle(radius));
    }

    [Fact]
    public void WrongShape()
    {
        var otherShape = new TestShape();
        var module = new CircleCalculationModule();
        Assert.Throws<WrongShapeTypeException>(() => module.GetSquare(ref otherShape));
    }

    private class TestShape : IShape
    {
        
    }
}