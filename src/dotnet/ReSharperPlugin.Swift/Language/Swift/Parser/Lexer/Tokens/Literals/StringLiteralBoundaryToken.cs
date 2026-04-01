using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;

/// <summary>
/// A common base class for tokens that represent the boundary (start or end) of a Swift string literal.
/// Stores the number of surrounding hashtags and marks itself as a string literal token.
/// </summary>
public abstract class StringLiteralBoundaryToken(string tokenId, int index)
    : SwiftTokenNodeType(tokenId, index)
{
    public override bool IsStringLiteral => true;

    public override string TokenRepresentation { get; } = tokenId;
}
