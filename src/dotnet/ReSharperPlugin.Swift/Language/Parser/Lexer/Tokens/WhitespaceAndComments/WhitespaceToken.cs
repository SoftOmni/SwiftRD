using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.WhitespaceAndComments;

public class WhitespaceToken() : SwiftTokenNodeType(SwiftTokens.WhitespaceId, SwiftTokens.WhitespaceIndex)
{
    public override string TokenRepresentation { get; } = SwiftTokens.WhitespaceId;

    public override bool IsWhitespace => true;
}