namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public class MultiLineStringLiteralStartToken(int numberOfHashtags) : StringLiteralBoundaryToken(
    BuildRepresentation(numberOfHashtags),
    numberOfHashtags > 0
        ? SwiftTokens.MultiLineSurroundedStringLiteralStartIndex
        : SwiftTokens.MultiLineStringLiteralStartIndex,
    numberOfHashtags)
{
    private static string BuildRepresentation(int numberOfHashtags)
    {
        var hashes = numberOfHashtags > 0 ? new string('#', numberOfHashtags) : string.Empty;
        return hashes + "\"\"\"";
    }
}
