using System;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.
    Literals.StringLiterals;

public class StringLiteralDelimiterCharacterInsertionException(
    IStringLiteral stringLiteral,
    char newCharacter,
    int index) : ArgumentException(GenerateMessage(stringLiteral, newCharacter, index))
{
    private static string GenerateMessage(IStringLiteral stringLiteral, char newCharacter, int index)
    {
        return
            $"Cannot insert the raw character '{newCharacter}' as the delimiters of the string literal\n" +
            $"{stringLiteral.Buffer} is that same character. (tried to insert at index {index})";
    }
}