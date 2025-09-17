using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Operators.BuiltinOperators;


public class BuiltinOperatorToken(string tokenId, int index) : SwiftTokenNodeType(tokenId, index)
{
    public override string TokenRepresentation { get; } = tokenId;
}
