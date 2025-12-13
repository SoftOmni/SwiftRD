using System;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Exceptions;

public class DuplicateAttachmentException<TOriginal, TDuplicated> : ArgumentException
{
    internal DuplicateAttachmentException(string name, string paramName)
        : base(GenerateMessage(name), paramName)
    { }

    private static string GenerateMessage(string name)
    {
        return $"""
                Error: cannot attach the child because the {name} of type {nameof(TDuplicated)} 
                is already defined for this {nameof(TOriginal)} 
                """;
    }
}