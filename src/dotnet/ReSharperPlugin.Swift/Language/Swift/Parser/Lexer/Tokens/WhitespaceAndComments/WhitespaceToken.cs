using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.WhitespaceAndComments;

public class WhitespaceToken() : SwiftTokenNodeType(SwiftTokens.WhitespaceId, SwiftTokens.WhitespaceIndex)
{
    public override string TokenRepresentation { get; } = SwiftTokens.WhitespaceId;

    public override bool IsWhitespace => true;
}