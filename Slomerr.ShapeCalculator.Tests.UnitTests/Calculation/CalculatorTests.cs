using Slomerr.ShapeCalculator.Calculation;
using Slomerr.ShapeCalculator.Exceptions;

namespace Slomerr.ShapeCalculator.Tests.UnitTests.Calculation;

public sealed class CalculatorTests
{
    [Fact]
    public void Calculate()
    {
        var calculator = new Calculator(new Dictionary<Type, ICalculationModule>
        {
            { typeof(TestShape1), new TestCalculationModule(1) }
        });
        var shape = new TestShape1();
        var result = calculator.GetSquare(ref shape);
        Assert.Equal(1, result);
    }

    [Fact]
    public void CalculateWrongShape()
    {
        var calculator = new Calculator(new Dictionary<Type, ICalculationModule>
        {
            { typeof(TestShape1), new TestCalculationModule(0) }
        });
        var shape = new TestShape2();
        Assert.Throws<NotFoundCalculationModuleException>(()=> calculator.GetSquare(ref shape));
    }
    
    private class TestShape1 : IShape
    {
        
    }

    private class TestShape2 : IShape
    {
        
    }

    private class TestCalculationModule : ICalculationModule
    {
        private readonly double _result;

        public TestCalculationModule(double result)
        {
            _result = result;
        }
        
        public double GetSquare<T>(ref T shape) where T : IShape
        {
            if (shape is TestShape1 testShape1)
            {
                return _result;
            }

            throw new WrongShapeTypeException(nameof(TestShape1), shape.GetType().Name);
        }
    }
}