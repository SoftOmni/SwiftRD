namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public class StringLiteralEndToken(int numberOfHashtags) : StringLiteralBoundaryToken(
    BuildRepresentation(numberOfHashtags),
    numberOfHashtags, 
    numberOfHashtags > 0 ? SwiftTokens.SurroundedStringLiteralEndId : SwiftTokens.StringLiteralEndId,
    numberOfHashtags > 0 ? SwiftTokens.SurroundedStringLiteralEndIndex : SwiftTokens.StringLiteralEndIndex)
{
    private static string BuildRepresentation(int numberOfHashtags)
    {
        return '"' + (numberOfHashtags > 0 ? new string('#', numberOfHashtags) : string.Empty);
    }
}