using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Punctuators;

public class PunctuatorToken(string punctuator, string tokenId, int index) : SwiftTokenNodeType(tokenId, index)
{
    public override string TokenRepresentation { get; } = punctuator;
}