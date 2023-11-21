namespace Slomerr.ShapeCalculator.Exceptions;

public sealed class ModuleIsAlreadyExistException : Exception
{
    public ModuleIsAlreadyExistException(string shape) 
        : base($"Module for the shape type {shape} already exist")
    {
    }
}