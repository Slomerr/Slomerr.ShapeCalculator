using Slomerr.ShapeCalculator.Exceptions;

namespace Slomerr.ShapeCalculator.DefaultShapes;

public class Triangle : IShape
{
    public float SideA { get; }
    public float SideB { get; }
    public float SideC { get; }

    public Triangle(float sideA, float sideB, float sideC)
    {
        if (!ValidateSides(sideA, sideB, sideC))
        {
            throw new WrongSidesOfTriangleException(sideA, sideB, sideC);
        }
        
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public static bool ValidateSides(float sideA, float sideB, float sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            return false;
        }

        return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
    }
}