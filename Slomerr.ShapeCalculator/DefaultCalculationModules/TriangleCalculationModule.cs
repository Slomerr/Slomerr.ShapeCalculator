using Slomerr.ShapeCalculator.DefaultShapes;
using Slomerr.ShapeCalculator.Exceptions;

namespace Slomerr.ShapeCalculator.DefaultCalculationModules;

internal sealed class TriangleCalculationModule : ICalculationModule
{
    public double GetSquare<T>(ref T shape) where T : IShape
    {
        if (shape is Triangle triangle)
        {
            var p = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;
            return Math.Sqrt(p * (p - triangle.SideA) * (p - triangle.SideB) * (p - triangle.SideC));
        }
        
        throw new WrongShapeTypeException(nameof(Triangle), shape.GetType().Name);
    }
}