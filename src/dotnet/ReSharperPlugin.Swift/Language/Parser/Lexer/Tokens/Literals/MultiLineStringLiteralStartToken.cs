namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public class MultiLineStringLiteralStartToken(int numberOfHashtags) : StringLiteralBoundaryToken(
    BuildRepresentation(numberOfHashtags),
    numberOfHashtags,
    numberOfHashtags > 0
        ? SwiftTokens.MultiLineSurroundedStringLiteralStartId
        : SwiftTokens.MultiLineStringLiteralStartId,
    numberOfHashtags > 0
        ? SwiftTokens.MultiLineSurroundedStringLiteralStartIndex
        : SwiftTokens.MultiLineStringLiteralStartIndex)
{
    private static string BuildRepresentation(int numberOfHashtags)
    {
        var hashes = numberOfHashtags > 0 ? new string('#', numberOfHashtags) : string.Empty;
        return hashes + "\"\"\"";
    }
}