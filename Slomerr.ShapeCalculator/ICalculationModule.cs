namespace Slomerr.ShapeCalculator;

public interface ICalculationModule
{
    double GetSquare<T>(ref T shape) where T : IShape;
}