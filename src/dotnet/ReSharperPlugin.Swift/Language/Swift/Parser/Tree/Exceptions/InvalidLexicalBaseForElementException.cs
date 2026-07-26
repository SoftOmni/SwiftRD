using System;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Exceptions;

public class InvalidLexicalBaseForElementException : ArgumentException
{
    internal InvalidLexicalBaseForElementException(string tokenId, IEditableBuffer buffer, string tokenValue)
        : base(GenerateMessage(tokenId, buffer, tokenValue))
    { }

    private static string GenerateMessage(string tokenId, IEditableBuffer buffer, string tokenValue)
    {
        return $"You tried to create a {tokenId} with the content of {buffer}. " +
               $"It didn't conform to the expected value {tokenValue}";
    }
}
