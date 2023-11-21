using Slomerr.ShapeCalculator.CalculatorBuilding;
using Slomerr.ShapeCalculator.Exceptions;

namespace Slomerr.ShapeCalculator.Tests.UnitTests.CalculatorBuilding;

public sealed class CalculatorBuildingTests
{
    [Fact]
    public void EmptyBuild()
    {
        var calculator = CalculatorBuilder.GetBuilder().Build();
        var shape = new TestShape1();
        Assert.Throws<NotFoundCalculationModuleException>(() => calculator.GetSquare(ref shape));
    }

    [Fact]
    public void BuildAddModule()
    {
        var calculator = CalculatorBuilder
            .GetBuilder()
            .AddCalculationModule<TestShape1, TestCalculationModule>()
            .Build();
        var shape = new TestShape1();
        var result = calculator.GetSquare(ref shape);
        Assert.Equal(1, result);
    }

    [Fact]
    public void BuildDuplicateShape()
    {
        var builder = CalculatorBuilder
            .GetBuilder()
            .AddCalculationModule<TestShape1, TestCalculationModule>()
            .AddCalculationModule<TestShape1, TestCalculationModule>();
        Assert.Throws<ModuleIsAlreadyExistException>(() => builder.Build());
    }

    private class TestShape1 : IShape
    {
        
    }

    public class TestCalculationModule : ICalculationModule
    {
        public double GetSquare<T>(ref T shape) where T : IShape
        {
            if (shape is TestShape1 testShape1)
            {
                return 1;
            }

            throw new WrongShapeTypeException(nameof(TestShape1), shape.GetType().Name);
        }
    }
}