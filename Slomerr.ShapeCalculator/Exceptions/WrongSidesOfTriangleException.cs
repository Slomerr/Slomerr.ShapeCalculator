namespace Slomerr.ShapeCalculator.Exceptions;

public sealed class WrongSidesOfTriangleException : Exception
{
    public WrongSidesOfTriangleException(float sideA, float sideB, float sideC) 
        : base($"Wrong sides of a triangle, they can't be equal or less than zero. SideA={sideB}, SideA={sideB}, SideC={sideC}")
    {
    }
}