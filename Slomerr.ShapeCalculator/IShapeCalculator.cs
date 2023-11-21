namespace Slomerr.ShapeCalculator;

public interface IShapeCalculator
{
    double GetSquare<T>(ref T shape) where T : IShape;
}