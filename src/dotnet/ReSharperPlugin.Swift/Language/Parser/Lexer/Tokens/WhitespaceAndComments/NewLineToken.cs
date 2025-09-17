using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.WhitespaceAndComments;

public class NewLineToken(string value) : SwiftTokenNodeType(SwiftTokens.NewlineId, SwiftTokens.NewlineIndex)
{
    public override bool IsWhitespace => true;

    public override string TokenRepresentation { get; } = value;
}