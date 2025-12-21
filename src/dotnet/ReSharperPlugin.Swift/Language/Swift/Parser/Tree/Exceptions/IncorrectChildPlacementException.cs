using System;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Exceptions;

public class IncorrectChildPlacementException : ArgumentException
{
    internal IncorrectChildPlacementException(string element, int elementIndex,
        string incorrectlyPlacedInRegardsToElementName, int incorrectlyPlacedInRegardsToElementIndex)
        : base(GenerateMessage(element, elementIndex, incorrectlyPlacedInRegardsToElementName, incorrectlyPlacedInRegardsToElementIndex))
    { }

    private static string GenerateMessage(string element, int elementIndex,
        string incorrectlyPlacedInRegardsToElementName, int incorrectlyPlacedInRegardsToElementIndex)
    {
        return $"""
               The {element} must be before the {incorrectlyPlacedInRegardsToElementName}'s index 
               (position {incorrectlyPlacedInRegardsToElementIndex} (you tried to set at {elementIndex}))",
               nameof(index));
               """;
    }
}