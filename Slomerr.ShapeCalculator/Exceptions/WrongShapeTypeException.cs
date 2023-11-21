namespace Slomerr.ShapeCalculator.Exceptions;

public sealed class WrongShapeTypeException : Exception
{
    public WrongShapeTypeException(string targetTypeName, string wrongTypeName) 
        : base($"The shape come not of the {targetTypeName} type, but of a different type {wrongTypeName}")
    {
        
    }
}