namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public class StringLiteralStartToken(int numberOfHashtags) : StringLiteralBoundaryToken(
    BuildRepresentation(numberOfHashtags),
    numberOfHashtags, 
    numberOfHashtags > 0 ? SwiftTokens.SurroundedStringLiteralStartId : SwiftTokens.StringLiteralStartId, 
    numberOfHashtags > 0 ? SwiftTokens.SurroundedStringLiteralStartIndex : SwiftTokens.StringLiteralStartIndex)
{
    private static string BuildRepresentation(int numberOfHashtags)
    {
        return (numberOfHashtags > 0 ? new string('#', numberOfHashtags) : string.Empty) + '"';
    }
}
