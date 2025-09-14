using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

/// <summary>
/// A common base class for tokens that represent the boundary (start or end) of a Swift string literal.
/// Stores the number of surrounding hashtags and marks itself as a string literal token.
/// </summary>
public abstract class StringLiteralBoundaryToken(string representation, int index, int numberOfHashtags)
    : SwiftTokenNodeType(representation, index)
{
    private readonly string _representation = representation;

    public int NumberOfHashtags { get; } = numberOfHashtags;

    public override bool IsStringLiteral => true;

    public override string TokenRepresentation => _representation;
}
