namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public class StringLiteralEndToken(int numberOfHashtags) : StringLiteralBoundaryToken(
    BuildRepresentation(numberOfHashtags),
    numberOfHashtags > 0 ? SwiftTokens.SurroundedStringLiteralEndIndex : SwiftTokens.StringLiteralEndIndex,
    numberOfHashtags)
{
    private static string BuildRepresentation(int numberOfHashtags)
    {
        return '"' + (numberOfHashtags > 0 ? new string('#', numberOfHashtags) : string.Empty);
    }
}
