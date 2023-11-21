using Slomerr.ShapeCalculator.DefaultShapes;
using Slomerr.ShapeCalculator.Exceptions;

namespace Slomerr.ShapeCalculator.DefaultCalculationModules;
internal sealed class CircleCalculationModule : ICalculationModule
{
    public double GetSquare<T>(ref T shape) where T : IShape
    {
        if (shape is Circle circle)
        {
            return Math.PI * Math.Pow(circle.Radius, 2);
        }

        throw new WrongShapeTypeException(nameof(Circle), shape.GetType().Name);
    }
}