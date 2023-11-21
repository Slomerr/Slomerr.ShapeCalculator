namespace Slomerr.ShapeCalculator.Exceptions;

public sealed class NotFoundCalculationModuleException : Exception
{
    public NotFoundCalculationModuleException(string shapeName) 
        : base($"Not found calculation module for shape {shapeName}")
    {
    }
}