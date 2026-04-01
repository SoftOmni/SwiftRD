using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Punctuators;

public class PunctuatorToken(string punctuator, string tokenId, int index) : SwiftTokenNodeType(tokenId, index)
{
    public override string TokenRepresentation { get; } = punctuator;
}