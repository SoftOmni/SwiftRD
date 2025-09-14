using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.WhitespaceAndComments;

public class WhitespaceToken(string whitespace) : SwiftTokenNodeType(whitespace, SwiftTokens.WhitespaceIndex)
{
    public override string TokenRepresentation { get; } = whitespace;

    public override bool IsWhitespace => true;
}