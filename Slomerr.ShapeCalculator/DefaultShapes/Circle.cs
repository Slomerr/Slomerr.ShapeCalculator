using Slomerr.ShapeCalculator.Exceptions;

namespace Slomerr.ShapeCalculator.DefaultShapes;

public class Circle : IShape
{
    public float Radius { get; }
    
    public Circle(float radius)
    {
        if (!Validate(radius))
        {
            throw new NegativeOrZeroRadiusException();
        }
        
        Radius = radius;
    }

    public static bool Validate(float radius)
    {
        return radius > 0;
    }
}